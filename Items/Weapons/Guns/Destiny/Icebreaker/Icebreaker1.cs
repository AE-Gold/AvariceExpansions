using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Projectiles.Destiny.Icebreaker;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Icebreaker
{
    public class Icebreaker1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Breaker");
            Tooltip.SetDefault("Replace operator if use causes fatal damage.\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.damage = 70;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 70;
            Item.useAnimation = 70;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 1, 50, 0);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shootSpeed = 16f;
            Item.crit = 16;
        }
        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient(ItemID.IceBlock, 50)
                .AddIngredient(ItemID.IllegalGunParts, 10)
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