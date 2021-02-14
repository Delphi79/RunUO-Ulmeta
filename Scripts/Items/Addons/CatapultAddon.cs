/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CatapultEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CatapultEastAddonDeed();
			}
		}

		[Constructable]
		public CatapultEastAddon()
		{
			AddComponent( new AddonComponent( 5749 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 5750 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 5752 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 5753 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 5773 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 5746 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 5768 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 5751 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 5747 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 5758 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 5748 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 5763 ), 0, -1, 0 );
		}

		public CatapultEastAddon( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CatapultEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CatapultEastAddon();
			}
		}

		[Constructable]
		public CatapultEastAddonDeed()
		{
			Name = "CatapultEast";
		}

		public CatapultEastAddonDeed( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CatapultSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CatapultSouthAddonDeed();
			}
		}

		[Constructable]
		public CatapultSouthAddon()
		{
			AddComponent( new AddonComponent( 5716 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 5707 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 5721 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 5708 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 5709 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 5706 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 5711 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 5731 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 5705 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 5726 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 5704 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 5710 ), 1, 1, 0 );
		}

		public CatapultSouthAddon( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CatapultSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CatapultSouthAddon();
			}
		}

		[Constructable]
		public CatapultSouthAddonDeed()
		{
			Name = "CatapultSouth";
		}

		public CatapultSouthAddonDeed( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CatapultWestAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CatapultWestAddonDeed();
			}
		}

		[Constructable]
		public CatapultWestAddon()
		{
			AddComponent( new AddonComponent( 5820 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 5831 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 5822 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 5823 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 5824 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 5819 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 5818 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 5825 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 5841 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 5821 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 5836 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 5817 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 5846 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 5826 ), 1, 1, 0 );
		}

		public CatapultWestAddon( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CatapultWestAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CatapultWestAddon();
			}
		}

		[Constructable]
		public CatapultWestAddonDeed()
		{
			Name = "CatapultWest";
		}

		public CatapultWestAddonDeed( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}