using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Kinetic;
using AvariceExpansions.Projectiles.Destiny.UniversalRemote;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.NoLandBeyond
{
    public class NoLandBeyond2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("No Land Beyond");
            Tooltip.SetDefault("Every hit blazes the path to our reclamation\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 65;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 35;
            Item.useAnimation = 35;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 2, 50, 0);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shootSpeed = 16f;
            Item.useAmmo = 40;
            Item.crit = 11;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<BoneToken>(1)
                .AddIngredient<NoLandBeyond1>(1)
                .AddTile(TileID.Anvils)
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

                default:
                    type = ProjectileType<KineticBullet>();
                    break;
            }
            /*if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = ProjectileType<KineticBullet>();
            }
            if (type == ProjectileID.FireArrow)
            {
                type = ProjectileType<FireArrowBullet>();
            }
            if (type == ProjectileID.BoneArrowFromMerchant)
            {
                type = ProjectileType<BoneArrowBullet>();
            }
            if (type == ProjectileID.UnholyArrow)
            {
                type = ProjectileType<UnholyArrowBullet>();
            }
            if (type == ProjectileID.FrostburnArrow)
            {
                type = ProjectileType<FrostburnArrowBullet>();
            }
            if (type == ProjectileID.JestersArrow)
            {
                type = ProjectileType<JestersArrowBullet>();
            }
            if (type == ProjectileID.HellfireArrow)
            {
                type = ProjectileType<HellfireArrowBullet>();
            }

            if (type == ProjectileID.MoonlordArrow || type == ProjectileID.VenomArrow || type == ProjectileID.IchorArrow || type == ProjectileID.ChlorophyteArrow || type == ProjectileID.CursedArrow || type == ProjectileID.HolyArrow)
            {
                type = ProjectileType<KineticBullet>();
            }*/
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }
    }
}