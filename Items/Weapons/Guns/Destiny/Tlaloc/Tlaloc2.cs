using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Tlaloc
{
    public class Tlaloc2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tlaloc");
            Tooltip.SetDefault("'Hold nothing back'\n[c/00A2C1:Infuses each shot with a portion of your mana]\n[c/02FF8A:Mark 2]");
        }

        public override void SetDefaults()
        {
            Item.damage = 34;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.rare = 7;
            Item.UseSound = SoundID.Item11;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
            Item.useAmmo = 97;
            Item.mana = 5;
            Item.shootSpeed = 16f;
            Item.crit = 21;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>() });
            return true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Tlaloc1", 1);
            recipe.AddIngredient(null, "PlanteraToken", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-13, 0);
        }
    }
}