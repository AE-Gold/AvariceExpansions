using AvariceExpansions.Items.Tokens;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.RedDeath
{
    public class RedDeath1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Death");
            Tooltip.SetDefault("'Guardian Killer.'\n[c/00A2C1:Shots fired from this weapon heal the player]\n[c/02FF8A:Mark 1]");
        }

        public override void SetDefaults()
        {
            Item.damage = 1;
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
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item31;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = -1;
            Item.shootSpeed = 16f;
            Item.consumeAmmoOnLastShotOnly = true;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<Projectiles.Destiny.RedDeath.RedDeath1>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8, -2);
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<EvilToken>(1)
                .AddTile(TileID.Anvils)
                .Register();
        }

    }
}