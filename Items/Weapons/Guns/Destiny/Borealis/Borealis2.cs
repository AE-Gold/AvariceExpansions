using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Borealis
{
    public class Borealis2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Borealis");
            Tooltip.SetDefault("Replace operator if use causes fatal damage.\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 200;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shootSpeed = 16f;
            Item.crit = 6;
            Item.useAmmo = 97;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<Borealis1>(1)
                .AddIngredient<Tokens.GolemToken>(1)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Arc.ArcBulletH>(), ProjectileType<Projectiles.Destiny.Solar.SolarBulletH>(), ProjectileType<Projectiles.Destiny.Void.VoidBulletH>() });
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8, -2);
        }
    }
}