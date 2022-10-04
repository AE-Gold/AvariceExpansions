using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.UniversalRemote
{
    public class UniversalRemote2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Universal Remote");
            Tooltip.SetDefault("This junker is a beast\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 1, 75, 0);
            Item.rare = 1;
            Item.UseSound = SoundID.Item36;
            Item.autoReuse = true;
            Item.useAmmo = 40;
            Item.shootSpeed = 16f;
            Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
            Item.crit = -1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "UniversalRemote1", 1);
            recipe.AddIngredient(null, "EyeToken", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>();
            }
            if (type == ProjectileID.FireArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.FireArrowBullet>();
            }
            if (type == ProjectileID.BoneArrowFromMerchant)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.BoneArrowBullet>();
            }
            if (type == ProjectileID.UnholyArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.UnholyArrowBullet>();
            }
            if (type == ProjectileID.FrostburnArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.FrostburnArrowBullet>();
            }
            if (type == ProjectileID.MoonlordArrow || type == ProjectileID.VenomArrow || type == ProjectileID.IchorArrow || type == ProjectileID.ChlorophyteArrow || type == ProjectileID.CursedArrow || type == ProjectileID.HolyArrow || type == ProjectileID.HellfireArrow || type == ProjectileID.JestersArrow)
            {
                type = ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>();
            }
            int numberProjectiles = 4 + Main.rand.Next(2);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-13, 0);
        }
    }
}