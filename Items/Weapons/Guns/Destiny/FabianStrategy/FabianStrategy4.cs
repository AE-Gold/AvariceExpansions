﻿using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Kinetic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.FabianStrategy
{
	public class FabianStrategy4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fabian Strategy");
			Tooltip.SetDefault("Stand by for respawn\nMark 4");
		}

		public override void SetDefaults()
		{
			Item.damage = 40;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 10;
			Item.height = 10;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item41;
			Item.autoReuse = true;
			Item.useAmmo = 97;
			Item.shootSpeed = 16f;
			Item.crit = 1;
		}

		public override void AddRecipes()
		{
			CreateRecipe()

				.AddIngredient<FabianStrategy3>(1)
				.AddIngredient<FleshToken>(1)
				.AddTile(TileID.Anvils)
				.Register();
		}

		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
		{
			type = ProjectileType<KineticBullet>();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
	}
}