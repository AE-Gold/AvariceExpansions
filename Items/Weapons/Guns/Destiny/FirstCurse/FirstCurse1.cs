﻿using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.FirstCurse
{
	public class FirstCurse1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The First Curse");
			Tooltip.SetDefault("When death becomes an afterthought\nMark 1");
		}

		public override void SetDefaults()
		{
			Item.damage = 60;
			Item.ranged = true;
			Item.width = 10;
			Item.height = 10;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.value = Item.sellPrice(0, 4, 0, 0);
			Item.rare = 5;
			Item.autoReuse = true;
			Item.shoot = Mod.Find<ModProjectile>("FirstCurseShot").Type;
			Item.useAmmo = 97;
			Item.shootSpeed = 16f;
			Item.scale = .9f;
		}

		public override bool CanUseItem(Player player)
		{
			if (AvariceExpansionsPlayer.CHit > 0)
			{
				Item.useStyle = 5;
				Item.useTime = 30;
				Item.useAnimation = 30;
				Item.damage = 60 + (AvariceExpansionsPlayer.CHit * 10);
				Item.useAmmo = 97;
				Item.crit = 1;
				Item.UseSound = SoundID.Item40;
			}
			else
			{
				Item.useStyle = 5;
				Item.useTime = 30;
				Item.useAnimation = 30;
				Item.damage = 60;
				Item.useAmmo = 97;
				Item.crit = 1;
				Item.UseSound = SoundID.Item40;
			}

			return base.CanUseItem(player);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.FirstCurse.FirstCurseShot>() });
			if (AvariceExpansionsPlayer.CHit > 0)
            {
				AvariceExpansionsPlayer.CHit -= 1;
			}
			return true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();

			recipe.AddIngredient(null, "LastWord1", 1);
			recipe.AddIngredient(null, "EvilToken", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(5, 1);
		}
	}
}