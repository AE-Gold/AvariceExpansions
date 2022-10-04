using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.Abbadon
{
    public class AbbadonShot : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AbbadonShot");
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
            if (target.life <= 0)
            {
                Projectile.NewProjectile((Projectile.Center.X + Main.rand.Next(-250, 250)), Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("AbbadonFire").Type, 15, 1, Main.myPlayer);
                Projectile.NewProjectile((Projectile.Center.X + Main.rand.Next(-250, 250)), Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("AbbadonFire").Type, 15, 1, Main.myPlayer);
                Projectile.NewProjectile((Projectile.Center.X + Main.rand.Next(-250, 250)), Projectile.Center.Y - 500f, 0, 16f, Mod.Find<ModProjectile>("AbbadonFire").Type, 15, 1, Main.myPlayer);
            }
            target.AddBuff(39, 120); /* Buff 39 is Cursed Inferno */
            target.AddBuff(204, 120); /* Buff 204 is Oiled */
        }
    }
}