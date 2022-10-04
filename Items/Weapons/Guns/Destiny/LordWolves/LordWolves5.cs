using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Solar;
using AvariceExpansions.Tiles;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.LordWolves
{
    public class LordWolves5 : ModItem
    {
        private int ammocount;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lord of Wolves");
            Tooltip.SetDefault("By this right alone do I rule.\n[c/00A2C1:Has a special right-click ability.]\n[c/02FF8A:Mark 5]");
        }

        public override void SetDefaults()
        {
            Item.damage = 70;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.knockBack = 1;
            Item.rare = ItemRarityID.Purple;
            Item.autoReuse = true;
            Item.width = 10;
            Item.height = 10;
            Item.crit = 2;
            Item.useAmmo = 97;
            Item.noMelee = true;
            Item.shootSpeed = 16f;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                Item.useTime = 3;
                Item.useAnimation = 15;
                Item.reuseDelay = 15;
                Item.UseSound = SoundID.Item31;
            }
            else
            {
                Item.useTime = 10;
                Item.useAnimation = 10;
                Item.reuseDelay = 10;
                Item.UseSound = SoundID.Item36;
            }

            return base.CanUseItem(player);
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            ammo.TurnToAir();

            if (player.altFunctionUse == 2)
            {
                for (ammocount = 0; ammocount < 4; ammocount++)
                {
                    player.ConsumeItem(ammo.type);
                }

                return true;
            }
            else
            {
                return true;
            }
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<SolarBulletML>();
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            const int NumProjectiles = 4;

            if (player.altFunctionUse == 2)
            {
                for (int i = 0; i < NumProjectiles; i++)
                {
                    Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(25));
                    newVelocity *= 1f - Main.rand.NextFloat(0.3f);  // Decrease velocity randomly for nicer visuals.
                    Projectile.NewProjectileDirect(source, position, newVelocity, type, 25, knockback, player.whoAmI);
                }
            }
            else
            {
                for (int i = 0; i < NumProjectiles; i++)
                {
                    Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(15));
                    newVelocity *= 1f - Main.rand.NextFloat(0.3f);  // Decrease velocity randomly for nicer visuals.
                    Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
                }
            }

            return false;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<LordWolves4>(1)
                .AddIngredient<LunarToken>(1)
                .AddTile<PAPTile>()
                .Register();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8, 1);
        }
    }
}