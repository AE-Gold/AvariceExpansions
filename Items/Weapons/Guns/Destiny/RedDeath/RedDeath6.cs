using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.RedDeath
{
    public class RedDeath6 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Death");
            Tooltip.SetDefault("'Guardian Killer.'\n[c/00A2C1:Shots fired from this weapon heal the player]\n[c/02FF8A:Mark 6]");
        }

        public override void SetDefaults()
        {
            Item.damage = 38;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 4;
            Item.useAnimation = 12;
            Item.reuseDelay = 14;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = 7;
            Item.UseSound = SoundID.Item31;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("RedDeath6").Type;
            Item.useAmmo = 97;
            Item.crit = -1;
            Item.shootSpeed = 16f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.RedDeath.RedDeath6>() });
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8, -2);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "RedDeath5", 1);
            recipe.AddIngredient(null, "GolemToken", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override bool ConsumeAmmo(Player player)
        {
            return !(player.ItemAnimation < Item.useAnimation - 2);
        }

    }
}