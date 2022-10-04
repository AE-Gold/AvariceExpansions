using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.RatKing
{
    public class RatKing3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rat King");
            Tooltip.SetDefault("'We are small, but we are legion.'\n[c/00A2C1:Successful shots grant invisibility]\n[c/00A2C1:Works better with others (WIP)]\n[c/02FF8A:Mark 3]");
        }

        public override void SetDefaults()
        {
            Item.damage = 14;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = 1;
            Item.UseSound = SoundID.Item98;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("RatKingShot3").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.scale = .75f;
            Item.crit = 2;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "EvilToken", 1);
            recipe.AddIngredient(null, "RatKing2", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.RatKing.RatKingShot3>() });
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(+6, 0);
        }

    }
}