using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.UniversalRemote;
using AvariceExpansions.Projectiles.Destiny.Kinetic;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.NoLandBeyond
{
    public class NoLandBeyond6 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("No Land Beyond");
            Tooltip.SetDefault("Every hit blazes the path to our reclamation\nMark 6");
        }

        public override void SetDefaults()
        {
            Item.damage = 250;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 35;
            Item.useAnimation = 35;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shootSpeed = 16f;
            Item.useAmmo = 40;
            Item.crit = 11;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<GolemToken>(1)
                .AddIngredient<NoLandBeyond5>(1)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            switch (type)
            {
                case ProjectileID.WoodenArrowFriendly:
                    type = ProjectileType<KineticBullet>();
                    break;

                case ProjectileID.FireArrow:
                    type = ProjectileType<FireArrowBullet>();
                    break;

                case ProjectileID.BoneArrowFromMerchant:
                    type = ProjectileType<BoneArrowBullet>();
                    break;

                case ProjectileID.UnholyArrow:
                    type = ProjectileType<UnholyArrowBullet>();
                    break;

                case ProjectileID.FrostburnArrow:
                    type = ProjectileType<FrostburnArrowBullet>();
                    break;

                case ProjectileID.JestersArrow:
                    type = ProjectileType<JestersArrowBullet>();
                    break;

                case ProjectileID.HellfireArrow:
                    type = ProjectileType<HellfireArrowBullet>();
                    break;

                case ProjectileID.IchorArrow:
                    type = ProjectileType<IchorArrowBullet>();
                    break;

                case ProjectileID.CursedArrow:
                    type = ProjectileType<CursedArrowBullet>();
                    break;

                case ProjectileID.HolyArrow:
                    type = ProjectileType<HolyArrowBullet>();
                    break;

                case ProjectileID.ChlorophyteArrow:
                    type = ProjectileType<ChlorophyteArrowBullet>();
                    break;

                case ProjectileID.VenomArrow:
                    type = ProjectileType<VenomArrowBullet>();
                    break;

                default:
                    type = ProjectileType<KineticBullet>();
                    break;
            }

            /*if (type == ProjectileID.WoodenArrowFriendly)
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
            if (type == ProjectileID.JestersArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.JestersArrowBullet>();
            }
            if (type == ProjectileID.HellfireArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.HellfireArrowBullet>();
            }
            if (type == ProjectileID.IchorArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.IchorArrowBullet>();
            }
            if (type == ProjectileID.CursedArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.CursedArrowBullet>();
            }
            if (type == ProjectileID.HolyArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.HolyArrowBullet>();
                int numberProjectiles = 2;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }
            if (type == ProjectileID.ChlorophyteArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.ChlorophyteArrowBullet>();
            }
            if (type == ProjectileID.VenomArrow)
            {
                type = ProjectileType<Projectiles.Destiny.UniversalRemote.VenomArrowBullet>();
            }
            if (type == ProjectileID.MoonlordArrow)
            {
                type = ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>();
            }
            return true;*/
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {

            if (type == ProjectileType<HolyArrowBullet>())
            {
                const int NumProjectiles = 3;

                for (int i = 0; i < NumProjectiles; i++)
                {
                    Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(2));
                    Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
                }
            }

            else
            {
                Projectile.NewProjectileDirect(source, position, velocity, type, damage, knockback, player.whoAmI);
            }
            return false;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }
    }
}