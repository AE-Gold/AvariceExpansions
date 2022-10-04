using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Huckleberry
{
    public class Huckleberry7 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Huckleberry");
            Tooltip.SetDefault("Nothin' in the world 30 rounds can't solve.\nMark 7");
        }

        public override void SetDefaults()
        {
            Item.damage = 35;
            Item.ranged = true;
            Item.useStyle = 5;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.knockBack = 1;
            Item.rare = 7;
            Item.autoReuse = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 7;
            Item.useAnimation = 7;
            Item.crit = -2;
            Item.shoot = 97;
            Item.useAmmo = 97;
            Item.noMelee = true;
            Item.shootSpeed = 16f;
            Item.UseSound = SoundID.Item11;
        }

        public override bool CanUseItem(Player player)
        {
            if (AvariceExpansionsPlayer.HuckleberryCounter >= 1)
            {
                Item.useTime = 7;
                Item.useAnimation = 7;
                Item.UseSound = SoundID.Item11;
                Item.useStyle = 5;
                Item.crit = -2;
                Item.useAmmo = 97;
                Item.damage = (35 + (7 * AvariceExpansionsPlayer.HuckleberryCounter));
            }
            else
            {
                Item.useTime = 7;
                Item.useAnimation = 7;
                Item.UseSound = SoundID.Item11;
                Item.useStyle = 5;
                Item.crit = -2;
                Item.useAmmo = 97;
                Item.damage = 35;
            }

            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Huckleberry.HuckleberryShot>() });
            return true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Huckleberry6", 1);
            recipe.AddIngredient(null, "GolemToken", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override bool ConsumeAmmo(Player player)
        {
            if (AvariceExpansionsPlayer.HuckleberryCounter > 0)
            {
                return Main.rand.NextFloat() >= .75f;
            }

            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, -2);
        }
    }
}