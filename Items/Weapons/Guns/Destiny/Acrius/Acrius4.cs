using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.DataStructures;
using AvariceExpansions.Projectiles.Destiny.Arc;
using AvariceExpansions.Tiles;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Acrius
{
    public class Acrius4 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acrius");
            Tooltip.SetDefault("Then he becomes Emperor.\nMark 4\n[c/D50000:We eat the mountains.]");
        }

        public override void SetDefaults()
        {
            Item.damage = 250;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item36;
            Item.autoReuse = true;
            Item.useAmmo = Mod.Find<ModItem>("HeavyAmmo").Type;
            Item.shootSpeed = 16f;
            Item.crit = -2;
        }
        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<Acrius3>(1)
                .AddIngredient<Tokens.LunarToken>(1)
                .AddTile<PAPTile>()
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<ArcBulletH>();
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            const int NumProjectiles = 10;

            for (int i = 0; i < NumProjectiles; i++)
            {
                Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(15));
                newVelocity *= 1f - Main.rand.NextFloat(0.3f);  // Decrease velocity randomly for nicer visuals.
                Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
            }

            return false;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-17, -3);
        }
    }
}