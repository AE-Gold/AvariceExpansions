using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.BadJuju;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.BadJuju
{
    public class BadJuju : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bad Juju");
            Tooltip.SetDefault("If you believe your weapon wants to end all existence, then so it will.");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 4;
            Item.useAnimation = 12;
            Item.reuseDelay = 14;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item31;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = -1;
            Item.shootSpeed = 16f;
            Item.scale = .85f;
            Item.consumeAmmoOnLastShotOnly = true;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<BadJujuShot>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20, 0);
        }
        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<EvilToken>(2)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}