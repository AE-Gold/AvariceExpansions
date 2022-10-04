using System;
using System.Collections.Generic;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Shaders;
using AvariceExpansions.Items.Weapons.Guns.Destiny.FabianStrategy;
using AvariceExpansions.Buffs.Suppressed;
using AvariceExpansions.Buffs.DevourMark;
using AvariceExpansions.Buffs;
using AvariceExpansions;

namespace AvariceExpansions
{
    public class AvariceExpansionsPlayer : ModPlayer
    {
        public static int CHit = 0;
        public static int FourthCounter = 0;
        public static int SturmCounter = 0;
        public static int DrangCounter = 0;
        public static int HuckleberryCounter = 0;
        public static int HuckleberryTimer = 0;
        public static int BGSpeed = 0;
        public static int BGDefense = 0;
        public static int BGTimer = 0;
        public static int ErianaTimer = 0;
        public static int CloudstrikeCritCounter = 0;
        public bool DevourMark1;
        public bool DevourMark2;
        public bool DevourMark3;
        public bool DevourMark3Super;
        public bool DevourMark4;
        public bool DevourMark4Super;
        public bool DevourMark5;
        public bool DevourMark5Super;
        public bool DevourMark6;
        public bool DevourMark6Super;
        public bool DevourMark7;
        public bool DevourMark7Super;


        public override void ResetEffects()
        {
            DevourMark1 = false;
            DevourMark2 = false;
            DevourMark3 = false;
            DevourMark3Super = false;
            DevourMark4 = false;
            DevourMark4Super = false;
            DevourMark5 = false;
            DevourMark5Super = false;
            DevourMark6 = false;
            DevourMark6Super = false;
            DevourMark7 = false;
            DevourMark7Super = false;

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy1").Type)
            {
                Player.statDefense += 10;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy2").Type)
            {
                Player.statDefense += 15;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy3").Type)
            {
                Player.statDefense += 20;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy4").Type)
            {
                Player.statDefense += 25;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy5").Type)
            {
                Player.statDefense += 30;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy6").Type)
            {
                Player.statDefense += 35;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy7").Type)
            {
                Player.statDefense += 40;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("FabianStrategy8").Type)
            {
                Player.statDefense += 50;
            }

            if ((Player.HeldItem.type == Mod.Find<ModItem>("PatienceTime1").Type) && (Player.velocity.X < 1f) && (Player.velocity.Y < 1f))
            {
                Player.AddBuff(10, 1); /* 10 is invisibility */
            }

            /*if ((player.HeldItem.type == mod.ItemType("RatKing1")) && player.team != 0 && Main.LocalPlayer.team = player.team)
            {
                player.AddBuff(mod.BuffType("RatBuff"), 1);
                LocalPlayer.AddBuff(mod.BuffType("RattBuff"), 1);
            }*/

            if (Player.HeldItem.type == Mod.Find<ModItem>("Mimicry").Type)
            {
                Player.statDefense += 10;
            }

            if (Player.HeldItem.type == Mod.Find<ModItem>("Eriana1").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana2").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana3").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana4").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana5").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana6").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana7").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana8").Type)
            {
                ErianaTimer--;
            }

            if (AvariceExpansionsPlayer.BGDefense > 1)
            {
                Player.AddBuff(Mod.Find<ModBuff>("BGDefense").Type, 120);
                Player.statDefense += (AvariceExpansionsPlayer.BGDefense * 3);
                BGTimer++;
                if (BGTimer > 300)
                {
                    Player.ClearBuff(Mod.Find<ModBuff>("BGDefense").Type);
                    BGDefense = 0;
                    BGTimer = 0;
                }
            }

            if (AvariceExpansionsPlayer.BGSpeed > 1)
            {
                Player.AddBuff(Mod.Find<ModBuff>("BGSpeed").Type, 120);
                Player.moveSpeed += (AvariceExpansionsPlayer.BGSpeed * .05f);
                BGTimer++;
                if (BGTimer > 300)
                {
                    Player.ClearBuff(Mod.Find<ModBuff>("BGSpeed").Type);
                    BGSpeed = 0;
                    BGTimer = 0;
                }
            }

            if (AvariceExpansionsPlayer.ErianaTimer <= 0 && (Player.HeldItem.type == Mod.Find<ModItem>("Eriana1").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana2").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana3").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana4").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana5").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana6").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana7").Type || Player.HeldItem.type == Mod.Find<ModItem>("Eriana8").Type))
            {
                Player.AddBuff(Mod.Find<ModBuff>("DeathGlance").Type, 120);
            }

            if (AvariceExpansionsPlayer.CHit > 0)
            {
                Player.AddBuff(Mod.Find<ModBuff>("FirstCurseBuff").Type, 120);
            }

            if (AvariceExpansionsPlayer.HuckleberryCounter > 0)
            {
                Player.AddBuff(Mod.Find<ModBuff>("Rampage").Type, 300);
            }

            if (AvariceExpansionsPlayer.SturmCounter > 0)
            {
                Player.AddBuff(Mod.Find<ModBuff>("SturmBuff").Type, 120);
            }

            if (Player.HasBuff(Mod.Find<ModBuff>("DrangBuff").Type))
            {
                AvariceExpansionsPlayer.DrangCounter = 1;
            }

            if (AvariceExpansionsPlayer.HuckleberryCounter > 0)
            {
                Player.AddBuff(Mod.Find<ModBuff>("Rampage").Type, 120);
                HuckleberryTimer++;
                if (HuckleberryTimer > 300)
                {
                    Player.ClearBuff(Mod.Find<ModBuff>("Rampage").Type);
                    HuckleberryCounter = 0;
                    HuckleberryTimer = 0;
                }
            }
           
        }

        public override void OnHitNPC(Item Item, NPC target, int damage, float knockback, bool crit)
        {
            if (target.HasBuff(Mod.Find<ModBuff>("Suppressed1").Type))
            {
                damage = (int)(damage * 1.1f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("Suppressed2").Type))
            {
                damage = (int)(damage * 1.25f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("Suppressed3").Type))
            {
                damage = (int)(damage * 1.5f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("TCSuppressed1").Type))
            {
                damage = (int)(damage * 1.5f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("TCSuppressed2").Type))
            {
                damage = (int)(damage * 2f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("TCSuppressed3").Type))
            {
                damage = (int)(damage * 2.5f);
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (target.HasBuff(Mod.Find<ModBuff>("Suppressed1").Type))
            {
                damage = (int)(damage * 1.1f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("Suppressed2").Type))
            {
                damage = (int)(damage * 1.25f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("Suppressed3").Type))
            {
                damage = (int)(damage * 1.5f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("TCSuppressed1").Type))
            {
                damage = (int)(damage * 1.5f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("TCSuppressed2").Type))
            {
                damage = (int)(damage * 2f);
            }

            if (target.HasBuff(Mod.Find<ModBuff>("TCSuppressed3").Type))
            {
                damage = (int)(damage * 2.5f);
            }
        }

        public override void UpdateDead()
        {
            AvariceExpansionsPlayer.CHit = 0;
            AvariceExpansionsPlayer.FourthCounter = 0;
            AvariceExpansionsPlayer.SturmCounter = 0;
            AvariceExpansionsPlayer.DrangCounter = 0;
            AvariceExpansionsPlayer.HuckleberryCounter = 0;
            AvariceExpansionsPlayer.BGSpeed = 0;
            AvariceExpansionsPlayer.BGDefense = 0;
            AvariceExpansionsPlayer.ErianaTimer = 0;
            AvariceExpansionsPlayer.CloudstrikeCritCounter = 0;
        }

        public override void UpdateBadLifeRegen()
        {
            if (DevourMark1)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 20;
            }

            if (DevourMark2)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 25;
            }

            if (DevourMark3)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 30;
            }

            if (DevourMark3Super)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 30;
            }

            if (DevourMark4)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 35;
            }

            if (DevourMark4Super)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 35;
            }

            if (DevourMark5)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 40;
            }

            if (DevourMark5Super)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 40;
            }

            if (DevourMark6)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 45;
            }

            if (DevourMark6Super)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 45;
            }

            if (DevourMark7)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 60;
            }

            if (DevourMark7Super)
            {
                if (Player.lifeRegen > 0)
                {
                    Player.lifeRegen = 0;
                }
                Player.lifeRegen -= 60;
            }
        }
    }
}
