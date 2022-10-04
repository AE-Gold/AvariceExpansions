using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Projectiles.Destiny.Arc;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.PatienceTime
{
    public class PatienceTime1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Patience and Time");
            Tooltip.SetDefault("That's all it takes really.\nStanding still turns you invisible.\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 1, 5, 0);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 29;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddRecipeGroup("AvariceExpansions:anyGoldBar", 10)
                .AddIngredient(ItemID.InvisibilityPotion, 3)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<ArcBulletPH>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, -4);
        }
    }
}