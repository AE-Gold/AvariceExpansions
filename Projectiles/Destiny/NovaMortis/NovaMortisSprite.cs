using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Projectiles.Destiny.NovaMortis
{
    public class NovaMortisSprite : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("NovaMortisSprite");
        }

        public override void SetDefaults()
        {
            Projectile.width = 24;
            Projectile.height = 74;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.ranged = true;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
        }
        
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            float num = 1.57079637f;
            Vector2 vector = player.RotatedRelativePoint(player.MountedCenter, true);
            if (Projectile.type == ProjectileType<Projectiles.Destiny.NovaMortis.NovaMortisSprite>())
            {
                Projectile.ai[0] += 1f;
                int num2 = 0;
                if (Projectile.ai[0] >= 60f)
                {
                    num2 += 1;
                }
                if (Projectile.ai[0] >= 120f)
                {
                    num2 += 1;
                }
                int num3 = 10;
                int num4 = 2;
                Projectile.ai[1] -= 1f;
                bool Shoot1 = false;
                if (Projectile.ai[1] <= 0f)
                {
                    Projectile.ai[1] = (float)(num3 - num4 * num2);
                    Shoot1 = true;
                }
                bool Shoot2 = player.channel && player.HasAmmo(player.HeldItem, true) && !player.noItems && !player.CCed;
                if (base.Projectile.soundDelay <= 0 && Shoot2)
                {
                    base.Projectile.soundDelay = num3 - num4 * num2;
                    if (base.Projectile.ai[0] != 1f)
                    {
                        SoundEngine.PlaySound(SoundID.Item11, base.Projectile.position);
                    }
                    base.Projectile.localAI[0] = 12f;
                }
                if (Shoot1 & Main.myPlayer == Projectile.owner)
                {
                    int ammotype = 14;
                    float scaleFactor2 = 16f;
                    int damage = player.GetWeaponDamage(player.HeldItem);
                    float knockBack = player.HeldItem.knockBack;
                    if (Shoot2)
                    {
                        player.PickAmmo(player.HeldItem, ref ammotype, ref scaleFactor2, ref Shoot2, ref damage, ref knockBack, false);
                        float scaleFactor = player.HeldItem.shootSpeed * Projectile.scale;
                        Vector2 value = vector;
                        Vector2 value2 = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY) - value;
                        if (player.gravDir == -1f)
                        {
                            value2.Y = (float)(Main.screenHeight - Main.mouseY) + Main.screenPosition.Y - value.Y;
                        }
                        Vector2 vector3 = Vector2.Normalize(value2);
                        if (float.IsNaN(vector3.X) || float.IsNaN(vector3.Y))
                        {
                            vector3 = -Vector2.UnitY;
                        }
                        vector3 *= scaleFactor;
                        if (vector3.X != Projectile.velocity.X || vector3.Y != Projectile.velocity.Y)
                        {
                            Projectile.netUpdate = true;
                        }
                        Projectile.velocity = vector3;
                        int num6 = ModContent.ProjectileType<Projectiles.Destiny.NovaMortis.NovaMortisShot>();
                        int num7 = 7;
                        value = Projectile.Center + new Vector2((float)Main.rand.Next(-num7, num7 + 1), (float)Main.rand.Next(-num7, num7 + 1));
                        Vector2 spinningpoint = Vector2.Normalize(Projectile.velocity) * scaleFactor2;
                        spinningpoint = Utils.RotatedBy(spinningpoint, Main.rand.NextDouble() * 0.19634954631328583 - 0.098174773156642914, default(Vector2));
                        if (float.IsNaN(spinningpoint.X) || float.IsNaN(spinningpoint.Y))
                        {
                            spinningpoint = -Vector2.UnitY;
                        }
                        Projectile.NewProjectile(value.X, value.Y, spinningpoint.X, spinningpoint.Y, num6, Projectile.damage, Projectile.knockBack, Projectile.owner, 0f, 0f);
                    }
                    else
                    {
                        Projectile.Kill();
                    }
                }
            }

            Projectile.position = player.RotatedRelativePoint(player.MountedCenter, true) - Projectile.Size / 2f;
            Projectile.rotation = Utils.ToRotation(Projectile.velocity) + num;
            Projectile.spriteDirection = Projectile.direction;
            Projectile.timeLeft = 2;
            player.ChangeDir(Projectile.direction);
            player.heldProj = Projectile.whoAmI;
            player.ItemTime = 2;
            player.ItemAnimation = 2;
            player.ItemRotation = (float)Math.Atan2((double)(Projectile.velocity.Y * (float)Projectile.direction), (double)(Projectile.velocity.X * (float)Projectile.direction));
        }
    }
}