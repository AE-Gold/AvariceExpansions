﻿using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.ZhaloSupercell
{
    public class ZhaloSupercellH : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ZhaloSupercellShot");
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
            Projectile.NewProjectile(Projectile.Center, Projectile.velocity.RotatedByRandom(MathHelper.Pi), Mod.Find<ModProjectile>("ZhaloSupercellSplitH").Type, 3, 1, Projectile.owner);
            Projectile.NewProjectile(Projectile.Center, Projectile.velocity.RotatedByRandom(MathHelper.Pi), Mod.Find<ModProjectile>("ZhaloSupercellSplitH").Type, 3, 1, Projectile.owner);
            Projectile.NewProjectile(Projectile.Center, Projectile.velocity.RotatedByRandom(MathHelper.Pi), Mod.Find<ModProjectile>("ZhaloSupercellSplitH").Type, 3, 1, Projectile.owner);
            target.AddBuff(32, 60);
        }
    }
}