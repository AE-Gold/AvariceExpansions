using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.Cloudstrike
{
    public class CloudstrikeShot3 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("CloudstrikeShot");
        }

        public override void SetDefaults()
        {
            Projectile.aiStyle = 1;
            Projectile.width = 2;
            Projectile.height = 2;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ranged = true;
            Projectile.alpha = 0;
            Projectile.light = .5f;
            Projectile.timeLeft = 600;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 1;
            AIType = ProjectileID.Bullet;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(32, 180); /* Buff 32 is Slow */
            if (target.life <= 0 && crit)
            {
                Projectile.NewProjectile(Projectile.Center.X, Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("CloudstrikeBolt").Type, 600, 1, Main.myPlayer);
            }

            if (target.life > 0 && crit)
            {
                AvariceExpansionsPlayer.CloudstrikeCritCounter++;

                if (AvariceExpansionsPlayer.CloudstrikeCritCounter == 3)
                {
                    Projectile.NewProjectile((Projectile.Center.X + Main.rand.Next(-100, 100)), Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("CloudstrikeBolt").Type, 450, 1, Main.myPlayer);
                    Projectile.NewProjectile((Projectile.Center.X + Main.rand.Next(-100, 100)), Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("CloudstrikeBolt").Type, 450, 1, Main.myPlayer);
                    Projectile.NewProjectile((Projectile.Center.X + Main.rand.Next(-100, 100)), Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("CloudstrikeBolt").Type, 450, 1, Main.myPlayer);
                    Projectile.NewProjectile((Projectile.Center.X + Main.rand.Next(-100, 100)), Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("CloudstrikeBolt").Type, 450, 1, Main.myPlayer);
                    
                    AvariceExpansionsPlayer.CloudstrikeCritCounter = 0;
                }
            }

            if (target.life <= 0)
            {
                AvariceExpansionsPlayer.CloudstrikeCritCounter = 0;
            }
        }
    }
}