using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Eriana
{
    public class Eriana7 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eriana's Vow");
            Tooltip.SetDefault("A Light in the Dark.\nMark 7");
        }

        public override void SetDefaults()
        {
            Item.damage = 300;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = 7;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("ErianaBulletH").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 6;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(Mod.Find<ModBuff>("DeathGlance").Type))
            {
                Item.useStyle = 5;
                Item.useTime = 30;
                Item.useAnimation = 30;
                Item.damage = 396;
                Item.useAmmo = 97;
                Item.crit = 6;
                Item.UseSound = SoundID.Item40;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 30;
                Item.useAnimation = 30;
                Item.damage = 300;
                Item.useAmmo = 97;
                Item.crit = 6;
                Item.UseSound = SoundID.Item40;
            }
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Eriana6", 1);
            recipe.AddIngredient(null, "GolemToken", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Eriana.ErianaBulletH>() });
            AvariceExpansionsPlayer.ErianaTimer = 240;
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, 0);
        }

    }
}