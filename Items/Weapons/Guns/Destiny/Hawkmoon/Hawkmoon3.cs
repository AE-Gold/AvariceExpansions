using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Hawkmoon
{
	public class Hawkmoon3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hawkmoon");
			Tooltip.SetDefault("Let loose thy talons\nMark 3");
		}

		public override void SetDefaults()
		{
			Item.damage = 70;
			Item.ranged = true;
			Item.width = 10;
			Item.height = 10;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.value = Item.sellPrice(0, 4, 0, 0);
			Item.rare = 5;
			Item.autoReuse = true;
			Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
			Item.useAmmo = 97;
			Item.shootSpeed = 16f;
			Item.scale = .8f;
		}

		public override bool CanUseItem(Player player)
		{
			if(Main.rand.Next(4) == 0)
			{
				Item.useStyle = 5;
				Item.useTime = 20;
				Item.useAnimation = 20;
				Item.damage = 140;
				Item.useAmmo = 97;
				Item.crit = 46;
				Item.UseSound = SoundID.Item38;
			}
			else
			{
				Item.useStyle = 5;
				Item.useTime = 20;
				Item.useAnimation = 20;
				Item.damage = 70;
				Item.useAmmo = 97;
				Item.crit = 1;
				Item.UseSound = SoundID.Item40;
			}

			return base.CanUseItem(player);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>() });
			return true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();

			recipe.AddIngredient(null, "Hawkmoon2", 1);
			recipe.AddIngredient(null, "MechanicalToken", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}
	}
}