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
    public class Eriana1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eriana's Vow");
            Tooltip.SetDefault("A Light in the Dark.\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.damage = 40;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.buyPrice(0, 4, 0, 0);
            Item.value = Item.sellPrice(0, 1, 75, 0);
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
                Item.damage = 53;
            }
            else
            {
                Item.damage = 40;
            }
            return base.CanUseItem(player);
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
