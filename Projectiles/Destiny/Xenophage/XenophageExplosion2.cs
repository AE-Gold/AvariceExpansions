using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.Xenophage
{
    public class XenophageExplosion2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("XenophageExplosion");
        }

        public override void SetDefaults()
        {
            Projectile.width = 200;
            Projectile.height = 200;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 30;
        }

        public override void AI()
        {
            int dustIndex = Dust.NewDust(Projectile.Center, 5, 5, 6, 0f, 0f, 0, default(Color), 1f);
            Dust.NewDust(Projectile.Center, 5, 5, 31, 0f, 0f, 0, default(Color), 1f);
        }
    }
}