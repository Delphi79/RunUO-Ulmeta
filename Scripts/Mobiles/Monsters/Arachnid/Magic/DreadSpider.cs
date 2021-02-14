using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a dread spider corpse" )]
	public class DreadSpider : BaseCreature
	{
		[Constructable]
		public DreadSpider () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a dread spider";
			Body = 11;
			BaseSoundID = 1170;

			SetStr( 196, 220 );
			SetDex( 126, 145 );
			SetInt( 286, 310 );

			SetHits( 118, 132 );

			SetDamage( 5, 17 );

			SetDamageType( ResistanceType.Physical, 20, 45 );
			SetDamageType( ResistanceType.Poison, 80, 120 );

			SetResistance( ResistanceType.Physical, 40, 70 );
			SetResistance( ResistanceType.Fire, 20, 80 );
			SetResistance( ResistanceType.Cold, 20, 50 );
			SetResistance( ResistanceType.Poison, 90, 120 );
			SetResistance( ResistanceType.Energy, 20, 70 );

			SetSkill( SkillName.EvalInt, 65.1, 120.0 );
			SetSkill( SkillName.Magery, 65.1, 180.0 );
			SetSkill( SkillName.Meditation, 65.1, 180.0 );
			SetSkill( SkillName.MagicResist, 45.1, 160.0 );
			SetSkill( SkillName.Tactics, 55.1, 170.0 );
			SetSkill( SkillName.Wrestling, 60.1, 175.0 );

			Fame = 5000;
			Karma = -3000;

			VirtualArmor = 36;

			PackItem( new SpidersSilk( 8 ) );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
		}

		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override Poison HitPoison{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 3; } }

		public DreadSpider( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( BaseSoundID == 263 )
				BaseSoundID = 1170;
		}
	}
}