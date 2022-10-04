using AvariceExpansions.Projectiles.Destiny.Cloudstrike;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Cloudstrike
{
    public class Cloudstrike1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cloudstrike");
            Tooltip.SetDefault("Meet this storm of sound and fury\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.damage = 150;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 21;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient(ItemID.SniperRifle, 1)
                .AddIngredient(ItemID.NimbusRod, 1)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<CloudstrikeShot1>();
        }
        
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-18, 0);
        }
    }
}