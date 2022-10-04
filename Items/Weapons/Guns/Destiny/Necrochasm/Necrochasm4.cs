using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Necrochasm;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Necrochasm
{
    public class Necrochasm4 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Necrochasm");
            Tooltip.SetDefault("Can you feel yourself slipping?\nMark 4");
        }

        public override void SetDefaults()
        {
            Item.damage = 22;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 4;
            Item.useAnimation = 4;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 4, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = 1;
            Item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<Necrochasm3>(1)
                .AddIngredient<MechanicalToken>(1)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<NecrochasmShot4>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-13, -2);
        }

    }
}