using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny
{
	public class HeavyAmmo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Ammo");
		}

		public override void SetDefaults()
		{
			Item.damage = 25;
			Item.ranged = true;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.knockBack = 1f;
			Item.value = Item.sellPrice(0, 0, 1, 0);
			Item.rare = 11;
			Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
			Item.shootSpeed = 16f;
			Item.ammo = Mod.Find<ModItem>("HeavyAmmo").Type;
		}
	}
}
