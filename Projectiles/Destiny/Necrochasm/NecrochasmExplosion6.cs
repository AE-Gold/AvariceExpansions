using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.Necrochasm
{
    public class NecrochasmExplosion6 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("NecrochasmExplosion");
        }

        public override void SetDefaults()
        {
            Projectile.width = 150;
            Projectile.height = 150;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 30;
        }

        public override void AI()
        {
            int dustIndex = Dust.NewDust(Projectile.Center, 5, 5, 15, 0f, 0f, 0, default(Color), 1f);
            Dust.NewDust(Projectile.Center, 5, 5, 15, 0f, 0f, 0, default(Color), 1f);
        }
    }
}