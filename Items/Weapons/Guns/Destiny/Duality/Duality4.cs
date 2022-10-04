using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Duality
{
    public class Duality4 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Duality");
            Tooltip.SetDefault("'To fire, not to aim.'\n[c/00A2C1:Fires a slug on right click.]\n[c/02FF8A:Mark 4]");
        }

        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = 11;
            Item.UseSound = SoundID.Item36;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Duality3", 1);
            recipe.AddIngredient(null, "LunarToken", 1);
            recipe.AddTile(null, "PAPTile");
            recipe.Register();
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                Item.useStyle = 5;
                Item.useTime = 36;
                Item.useAnimation = 36;
                Item.reuseDelay = 18;
                Item.damage = 500;
                Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
                Item.useAmmo = 97;
                Item.crit = 21;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 16;
                Item.useAnimation = 16;
                Item.reuseDelay = 18;
                Item.damage = 50;
                Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
                Item.useAmmo = 97;
                Item.crit = 6;
            }

            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {
                type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>() });
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(0));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, 500, knockBack, player.whoAmI);
            }
            else
            {
                type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>() });
                int numberProjectiles = 4 + Main.rand.Next(2);
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, 50, knockBack, player.whoAmI);
                }
            }
            return false;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, +4);
        }
    }
}