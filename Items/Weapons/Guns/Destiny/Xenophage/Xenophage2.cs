using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Xenophage
{
    public class Xenophage2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xenophage");
            Tooltip.SetDefault("This might sting a little.\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.ranged = true;
            Item.width = 20;
            Item.height = 20;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = 7;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("XenophageShot2").Type;
            Item.useAmmo = Mod.Find<ModItem>("HeavyAmmo").Type;
            Item.crit = 1;
            Item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Xenophage1", 1);
            recipe.AddIngredient(null, "GolemToken", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Xenophage.XenophageShot2>() });
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5, 0);
        }

    }
}