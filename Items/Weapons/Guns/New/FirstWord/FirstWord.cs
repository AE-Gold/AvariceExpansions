using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Items.Weapons.Guns.New.FirstWord
{
    public class FirstWord : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The First Word");
            Tooltip.SetDefault("'Bang.'\n[c/00A2C1:Gains damage on hits]");
        }

        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.ranged = true;
            Item.useStyle = 5;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.knockBack = 2;
            Item.rare = 11;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.width = 10;
            Item.height = 10;
            Item.crit = 11;
            Item.shoot = 97;
            Item.useAmmo = 97;
            Item.noMelee = true;
            Item.shootSpeed = 16f;
            Item.scale = .9f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "LunarToken", 1);
            recipe.AddIngredient(null, "LastWord4", 1);
            recipe.AddIngredient(null, "FirstCurse4", 1);
            recipe.AddTile(null, "PAPTile");
            recipe.Register();
        }

        public override bool CanUseItem(Player player)
        {
            if (AvariceExpansionsPlayer.CHit > 0)
            {
                Item.useStyle = 5;
                Item.useTime = 7;
                Item.useAnimation = 7;
                Item.reuseDelay = 7;
                Item.damage = 100 + (AvariceExpansionsPlayer.CHit * 100);
                Item.useAmmo = 97;
                Item.crit = 11;
                Item.UseSound = SoundID.Item40;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 7;
                Item.useAnimation = 7;
                Item.reuseDelay = 7;
                Item.damage = 100;
                Item.useAmmo = 97;
                Item.crit = 11;
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

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(5, 1);
        }
    }
}