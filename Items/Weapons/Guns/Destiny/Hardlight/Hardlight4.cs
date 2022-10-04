using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Hardlight;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Hardlight
{
	public class Hardlight4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault ("Hardlight");
			Tooltip.SetDefault ("'Three new products for the price of one!'\n[c/00A2C1:Projectiles ricochet and pierce]\n[c/00A2C1:Fires arc, solar, and void Projectiles!]\n[c/02FF8A:Mark 4]");
		}
		
		public override void SetDefaults()
		{
			Item.damage = 60;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 10;
			Item.height = 10;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.value = Item.sellPrice(0, 6, 0, 0);
			Item.rare = ItemRarityID.Lime;
			Item.UseSound = SoundID.Item115;
			Item.autoReuse = true;
			Item.useAmmo = 97;
			Item.shootSpeed = 16f;
            Item.crit = 0;
		}

		public override void AddRecipes()
		{
			CreateRecipe()

				.AddIngredient<Hardlight3>(1)
				.AddIngredient<GolemToken>(1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = Main.rand.Next(new int[] { ProjectileType<HardlightArc4>(), ProjectileType<HardlightSolar4>(), ProjectileType<HardlightVoid4>() });
		}

		public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, 0);
        }
    }
}