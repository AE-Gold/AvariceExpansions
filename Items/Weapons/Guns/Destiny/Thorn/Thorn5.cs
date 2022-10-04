﻿using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Thorn
{
	public class Thorn5 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thorn");
			Tooltip.SetDefault("'To rend one's enemies...'\n[c/00A2C1:Projectiles poision enemies]\n[c/00A2C1:Kills buff poison]\n[c/02FF8A:Mark 5]");
		}

		public override void SetDefaults()
		{
			Item.damage = 35;
			Item.ranged = true;
			Item.width = 10;
			Item.height = 10;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.value = Item.sellPrice(0, 5, 0, 0);
			Item.rare = 7;
			Item.UseSound = SoundID.Item41;
			Item.autoReuse = true;
			Item.shoot = Mod.Find<ModProjectile>("ThornBullet5").Type;
			Item.useAmmo = 97;
			Item.shootSpeed = 16f;
			Item.crit = -1;
			Item.scale = .8f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (player.HasBuff(Mod.Find<ModBuff>("SoulDevourer").Type))
            {
				type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Thorn.ThornBullet5Super>() });
			}
			else
            {
				type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Thorn.ThornBullet5>() });
			}
			return true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();

			recipe.AddIngredient(null, "Thorn4", 1);
			recipe.AddIngredient(null, "PlanteraToken", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}
	}
}