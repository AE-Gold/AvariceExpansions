using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items
{
	public class StinkyBullets : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stinky Bullets");
		}

		public override void SetDefaults()
		{
			Item.damage = 5;
			Item.ranged = true;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.knockBack = 1f;
			Item.value = Item.sellPrice(0, 0, 0, 1);
			Item.rare = 0;
			Item.shoot = Mod.Find<ModProjectile>("StinkyBullets").Type;
			Item.shootSpeed = 16f;
			Item.ammo = Mod.Find<ModItem>("StinkyBullets").Type;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(75);

			recipe.AddIngredient(ItemID.MusketBall, 75);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ItemID.Deathweed, 1);
			recipe.AddIngredient(ItemID.Stinkfish, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
