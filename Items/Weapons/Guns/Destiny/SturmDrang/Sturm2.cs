using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.SturmDrang
{
    public class Sturm2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sturm");
            Tooltip.SetDefault("To Sigrun, from Victor\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 25;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = 4;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("SturmBullet").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 2;
            Item.scale = .8f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Sturm1", 1);
            recipe.AddIngredient(null, "FleshToken", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        public override bool CanUseItem(Player player)
        {
            if (AvariceExpansionsPlayer.SturmCounter > 0)
            {
                Item.useStyle = 5;
                Item.useTime = 20;
                Item.useAnimation = 20;
                Item.damage = 25 + (AvariceExpansionsPlayer.SturmCounter * 25);
                Item.useAmmo = 97;
                Item.crit = 2;
                Item.UseSound = SoundID.Item41;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 20;
                Item.useAnimation = 20;
                Item.damage = 25;
                Item.useAmmo = 97;
                Item.crit = 2;
                Item.UseSound = SoundID.Item41;
            }

            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.SturmDrang.SturmBullet>() });
            AvariceExpansionsPlayer.SturmCounter = 0;
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(8, -2);
        }

    }
}