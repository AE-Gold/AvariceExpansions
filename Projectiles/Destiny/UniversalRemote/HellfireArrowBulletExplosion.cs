using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.UniversalRemote
{
    public class HellfireArrowBulletExplosion : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HellfireArrowBulletExplosion");
        }

        public override void SetDefaults()
        {
            Projectile.width = 50;
            Projectile.height = 50;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 10;
        }

        public override void AI()
        {
            int dustIndex = Dust.NewDust(Projectile.Center, 5, 5, 6, 0f, 0f, 0, default(Color), 1f);
            Dust.NewDust(Projectile.Center, 5, 5, 31, 0f, 0f, 0, default(Color), 1f);
        }
    }
}