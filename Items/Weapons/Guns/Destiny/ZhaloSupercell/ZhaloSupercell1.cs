using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.ZhaloSupercell
{
    public class ZhaloSupercell1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zhalo Supercell");
            Tooltip.SetDefault("'An upcycled torrent of righteous thunder.'\n[c/02FF8A:Mark 1]");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 8;
            Item.useAnimation = 8;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 2;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("ZhaloSupercellShot").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.ZhaloSupercell.ZhaloSupercell1>() });
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20, 0);
        }
    }
}