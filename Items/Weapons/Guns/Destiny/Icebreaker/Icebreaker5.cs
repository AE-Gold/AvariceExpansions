using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Projectiles.Destiny.Icebreaker;
using AvariceExpansions.Items.Tokens;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Icebreaker
{
    public class Icebreaker5 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Breaker");
            Tooltip.SetDefault("Replace operator if use causes fatal damage.\nMark 5");
        }

        public override void SetDefaults()
        {
            Item.damage = 150;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 60;
            Item.useAnimation = 60;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shootSpeed = 16f;
            Item.crit = 16;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<Icebreaker4>(1)
                .AddIngredient<FleshToken>(1)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<IceBBullet>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, -3);
        }
    }
}