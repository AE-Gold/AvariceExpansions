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
    public class Drang6 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Drang");
            Tooltip.SetDefault("To Victor, from Sigrun\nMark 6");
        }

        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = 11;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("DrangBulletML").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 2;
            Item.scale = .7f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Drang5", 1);
            recipe.AddIngredient(null, "LunarToken", 1);
            recipe.AddTile(null, "PAPTile");
            recipe.Register();
        }

        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(Mod.Find<ModBuff>("DrangBuff").Type))
            {
                Item.useStyle = 5;
                Item.useTime = (10 - AvariceExpansionsPlayer.DrangCounter);
                Item.useAnimation = (10 - AvariceExpansionsPlayer.DrangCounter);
                Item.damage = 50;
                Item.useAmmo = 97;
                Item.crit = 2;
                Item.UseSound = SoundID.Item41;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 10;
                Item.useAnimation = 10;
                Item.damage = 50;
                Item.useAmmo = 97;
                Item.crit = 2;
                Item.UseSound = SoundID.Item41;
            }

            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.SturmDrang.DrangBulletML>() });
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2, 2);
        }

    }
}