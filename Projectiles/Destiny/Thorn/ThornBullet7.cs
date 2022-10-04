using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.Thorn
{
    public class ThornBullet7 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ThornBullet7");
        }

        public override void SetDefaults()
        {
            Projectile.width = 6;
            Projectile.height = 6;
            Projectile.aiStyle = 1;
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
            DrawOffsetX = -4;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(Mod.Find<ModBuff>("DevourMark7").Type, 600);
           
            if (target.life <= 0)
            {
                Player p = Main.player[Projectile.owner];
                p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 600);
            }
        }
        
        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }
    }
}