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
    public class Eriana2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eriana's Vow");
            Tooltip.SetDefault("A Light in the Dark.\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 70;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = 1;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("ErianaBulletPH").Type;
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
                Item.damage = 92;
                Item.useAmmo = 97;
                Item.crit = 6;
                Item.UseSound = SoundID.Item40;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 30;
                Item.useAnimation = 30;
                Item.damage = 70;
                Item.useAmmo = 97;
                Item.crit = 6;
                Item.UseSound = SoundID.Item40;
            }
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "Eriana1", 1);
            recipe.AddIngredient(null, "EvilToken", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Eriana.ErianaBulletPH>() });
            AvariceExpansionsPlayer.ErianaTimer = 240;
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, 0);
        }

    }
}