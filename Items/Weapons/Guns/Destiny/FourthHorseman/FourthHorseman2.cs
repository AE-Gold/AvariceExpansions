using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.FourthHorseman
{
    public class FourthHorseman2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Fourth Horseman");
            Tooltip.SetDefault("Pathfinder.\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.ranged = true;
            Item.useStyle = 5;
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.knockBack = 1;
            Item.rare = 7;
            Item.autoReuse = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 11;
            Item.useAnimation = 11;
            Item.crit = 1;
            Item.shoot = 97;
            Item.useAmmo = 97;
            Item.noMelee = true;
            Item.shootSpeed = 16f;
            Item.UseSound = SoundID.Item36;
        }

        public override bool CanUseItem(Player player)
        {
            if (AvariceExpansionsPlayer.FourthCounter >= 1)
            {
                Item.useTime = 11;
                Item.useAnimation = 11;
                Item.UseSound = SoundID.Item36;
                Item.useStyle = 5;
                Item.crit = 1;
                Item.useAmmo = 97;
                Item.damage = (15 + (AvariceExpansionsPlayer.FourthCounter * 3));
            }
            else
            {
                Item.useTime = 11;
                Item.useAnimation = 11;
                Item.UseSound = SoundID.Item36;
                Item.useStyle = 5;
                Item.crit = 1;
                Item.useAmmo = 97;
                Item.damage = 15;
            }

            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (AvariceExpansionsPlayer.FourthCounter >= 1)
            {
                type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Arc.ArcBulletH>() });
                int numberProjectiles = 4;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10 + (AvariceExpansionsPlayer.FourthCounter * 3)));
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }
            else
            {
                type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Arc.ArcBulletH>() });
                int numberProjectiles = 4;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }
            if (AvariceExpansionsPlayer.FourthCounter < 6)
            {
                AvariceExpansionsPlayer.FourthCounter += 1;
            }
            if (AvariceExpansionsPlayer.FourthCounter == 6)
            {
                AvariceExpansionsPlayer.FourthCounter = 0;
            }
            return true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "FourthHorseman1", 1);
            recipe.AddIngredient(null, "PlanteraToken", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-11, 0);
        }
    }
}