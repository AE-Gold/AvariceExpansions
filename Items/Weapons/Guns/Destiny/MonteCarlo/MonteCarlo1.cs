using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.MonteCarlo;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.MonteCarlo
{
    public class MonteCarlo1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Monte Carlo");
            Tooltip.SetDefault("'Roll with it.'\n[c/00A2C1:Hits provide a buff to melee damage]\n[c/02FF8A:Mark 1]");
        }

        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 9;
            Item.useAnimation = 9;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 2, 50, 0);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = 1;
            Item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<BoneToken>(8)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<MonteCarloShot1>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20, 0);
        }

    }
}