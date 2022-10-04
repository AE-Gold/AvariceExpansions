using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Crimson;
using AvariceExpansions.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Crimson
{
    public class Crimson7 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson");
            Tooltip.SetDefault("Here's the remedy.\nMark 7");
        }

        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 4;
            Item.useAnimation = 12;
            Item.reuseDelay = 14;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item31;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = -1;
            Item.shootSpeed = 16f;
            Item.scale = .9f;
            Item.consumeAmmoOnLastShotOnly = true;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<CrimsonShot2>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 0);
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<Crimson6>(1)
                .AddIngredient<LunarToken>(1)
                .AddTile<PAPTile>()
                .Register();
        }
    }
}