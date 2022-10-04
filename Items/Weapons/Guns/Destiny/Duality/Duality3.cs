using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Duality
{
    public class Duality3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Duality");
            Tooltip.SetDefault("'To fire, not to aim.'\n[c/00A2C1:Fires a slug on right click.]\n[c/02FF8A:Mark 3]");
        }

        public override void SetDefaults()
        {
            Item.damage = 30;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = 7;
            Item.UseSound = SoundID.Item36;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 6;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Duality2", 1);
            recipe.AddIngredient(null, "GolemToken", 1);
            recipe.AddTile(TileID.MythrilAnvil);
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
                Item.damage = 250;
                Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
                Item.useAmmo = 97;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 16;
                Item.useAnimation = 16;
                Item.reuseDelay = 18;
                Item.damage = 30;
                Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
                Item.useAmmo = 97;
            }

            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, Mod.Find<ModProjectile>("KineticBullet").Type, (int)((double)damage * 8), knockBack, Main.myPlayer);
            }
            else
            {
                int numberProjectiles = 4 + Main.rand.Next(2);
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, Mod.Find<ModProjectile>("KineticBullet").Type, damage, knockBack, Main.myPlayer);
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