using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Misc;
using Server.Items;
using Server.Gumps;

namespace Server.Mobiles
{
	public abstract class BaseHealer : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos { get { return m_SBInfos; } }

		public override bool IsActiveVendor { get { return false; } }
		public override bool IsInvulnerable { get { return false; } }

		public override void InitSBInfo()
		{
		}

		public BaseHealer()
			: base( null )
		{
			if( !IsInvulnerable )
			{
				AI = AIType.AI_Mage;
				ActiveSpeed = 0.2;
				PassiveSpeed = 0.8;
				RangePerception = BaseCreature.DefaultRangePerception;
				FightMode = FightMode.Aggressor;
			}

			SpeechHue = 0;

			SetStr( 304, 400 );
			SetDex( 102, 150 );
			SetInt( 204, 300 );

			SetDamage( 10, 23 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 40, 50 );
			SetResistance( ResistanceType.Fire, 40, 50 );
			SetResistance( ResistanceType.Cold, 40, 50 );
			SetResistance( ResistanceType.Poison, 40, 50 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.Anatomy, 75.0, 97.5 );
			SetSkill( SkillName.EvalInt, 82.0, 100.0 );
			SetSkill( SkillName.Healing, 75.0, 97.5 );
			SetSkill( SkillName.Magery, 82.0, 100.0 );
			SetSkill( SkillName.MagicResist, 82.0, 100.0 );
			SetSkill( SkillName.Tactics, 82.0, 100.0 );

			Fame = 1000;
			Karma = 10000;

			PackItem( new Bandage( Utility.RandomMinMax( 5, 10 ) ) );
			PackItem( new HealPotion() );
			PackItem( new CurePotion() );
		}

		public override VendorShoeType ShoeType { get { return VendorShoeType.Sandals; } }

		public virtual int GetRobeColor()
		{
			return Utility.RandomYellowHue();
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new Robe( GetRobeColor() ) );
		}

		public virtual bool HealsAndCures { get { return true; } }

		public virtual bool CheckResurrect( Mobile m )
		{
			return true;
		}

		private DateTime m_NextResurrect;
		private static TimeSpan ResurrectDelay = TimeSpan.FromSeconds( 2.0 );

		public virtual void OfferResurrection( Mobile m )
		{
			if( m is PlayerMobile && !m.Alive ) //((PlayerMobile)m).PermaDead )
			{
				Say( "I am sorry. I can offer thee no help." );
				return;
			}

			Direction = GetDirectionTo( m );
			Say( 501224 ); // Thou hast strayed from the path of virtue, but thou still deservest a second chance.

			m.PlaySound( 0x214 );
			m.FixedEffect( 0x376A, 10, 16 );

			m.CloseGump( typeof( ResurrectGump ) );
			m.SendGump( new ResurrectGump( m, ResurrectMessage.Healer ) );
		}

		public virtual void OfferHeal( PlayerMobile m )
		{
			Direction = GetDirectionTo( m );

			Say( 501229 ); //You look like you need some healing my child.

			m.PlaySound( 0x1F2 );
			m.FixedEffect( 0x376A, 9, 32 );

			m.Hits = m.HitsMax;
			m.Poison = null;
		}

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( !m.Frozen && DateTime.Now >= m_NextResurrect && InRange( m, 4 ) && !InRange( oldLocation, 4 ) && InLOS( m ) )
			{
				if( !m.Alive )
				{
					m_NextResurrect = DateTime.Now + ResurrectDelay;

					if( m.Map == null || !m.Map.CanFit( m.Location, 16, false, false ) )
					{
						m.SendLocalizedMessage( 502391 ); // Thou can not be resurrected there!
					}
					else if( CheckResurrect( m ) )
					{
						OfferResurrection( m );
					}
				}
				else if( this.HealsAndCures && (m.Hits < m.HitsMax || m.Poison != null) && m is PlayerMobile )
				{
					OfferHeal( (PlayerMobile)m );
				}
			}
		}

		public BaseHealer( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			if( !IsInvulnerable )
			{
				AI = AIType.AI_Mage;
				ActiveSpeed = 0.2;
				PassiveSpeed = 0.8;
				RangePerception = BaseCreature.DefaultRangePerception;
				FightMode = FightMode.Aggressor;
			}
		}
	}
}