using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Necrochasm;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Necrochasm
{
    public class Necrochasm3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Necrochasm");
            Tooltip.SetDefault("Can you feel yourself slipping?\nMark 3");
        }

        public override void SetDefaults()
        {
            Item.damage = 18;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 4;
            Item.useAnimation = 4;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = 1;
            Item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<Necrochasm2>(1)
                .AddIngredient<FleshToken>(1)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<NecrochasmShot3>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-13, -2);
        }

    }
}