using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameContent;
using AvariceExpansions.Items.Weapons.Guns.Destiny.Hardlight;
using AvariceExpansions.Items.Weapons.Guns.Destiny.Hawkmoon;
using AvariceExpansions.Items.Weapons.Guns.Destiny.MonteCarlo;
using AvariceExpansions.Items.Weapons.Guns.Destiny.LordWolves;
using AvariceExpansions.Items.Weapons.Guns.Destiny.FabianStrategy;
using AvariceExpansions.Items.Weapons.Guns.Destiny.Eriana;
using AvariceExpansions.Buffs;
using AvariceExpansions.Buffs.DevourMark;
using AvariceExpansions;
using AvariceExpansions.Items.Tokens;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions
{
    public class AvariceExpansionsGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;

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

        public override void ResetEffects(NPC npc)
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
        }

        public override void OnKill(NPC npc)
        {
            if(npc.type == NPCID.WallofFlesh && !Main.expertMode)
            {
                if(Main.rand.Next(8) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("Hardlight1").Type);
                if(Main.rand.Next(8) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("LordWolves1").Type);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("FleshToken").Type, 1);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(20, 30));
            }

            if(npc.type == NPCID.Mothron)
            {
                if (Main.rand.Next(5) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("Despair").Type);
            }

            if(npc.type == NPCID.SkeletronHead && !Main.expertMode)
            {
                if(Main.rand.Next(8) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("MonteCarlo1").Type);
                if (Main.rand.Next(8) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("SweetBusiness1").Type);
                if (Main.rand.Next(8) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("Hawkmoon1").Type);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("BoneToken").Type, 1);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(15, 20));
            }

            if(npc.type == NPCID.EyeofCthulhu && !Main.expertMode)
            {
                if (Main.rand.Next(8) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("FabianStrategy1").Type);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("EyeToken").Type, 1);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(5, 10));
            }

            if(npc.type == NPCID.Golem && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("GolemToken").Type, 1);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(50, 75));
            }

            if(npc.type == NPCID.Plantera && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("PlanteraToken").Type, 1);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(40, 50));
            }

            if(npc.type == NPCID.MoonLordCore && !Main.expertMode)
            {
                if (Main.rand.Next(8) == 0)
                    Item.NewItem(npc.getRect(), Mod.Find<ModItem>("Whisper").Type);
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, 200);
            }

            if(npc.type == NPCID.BrainofCthulhu && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(10, 15));
            }

            if((npc.type == NPCID.EaterofWorldsHead || npc.type == NPCID.EaterofWorldsBody || npc.type == NPCID.EaterofWorldsTail) && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, 1);
            }

            if((npc.type == NPCID.SkeletronPrime || npc.type == NPCID.TheDestroyer) && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(30, 40));
            }

            if((npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism) && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(15, 20));
            }

            if (npc.HasBuff(Mod.Find<ModBuff>("DevourMark3").Type) && npc.life <= 0)
            {
                Player p = Main.player[Main.myPlayer];
                p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 300);
            }

            if (npc.HasBuff(Mod.Find<ModBuff>("DevourMark4").Type) && npc.life <= 0)
            {
                Player p = Main.player[Main.myPlayer];
                p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 300);
            }

            if (npc.HasBuff(Mod.Find<ModBuff>("DevourMark5").Type) && npc.life <= 0)
            {
                Player p = Main.player[Main.myPlayer];
                p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 300);
            }

            if (npc.HasBuff(Mod.Find<ModBuff>("DevourMark6").Type) && npc.life <= 0)
            {
                Player p = Main.player[Main.myPlayer];
                p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 300);
            }

            if (npc.HasBuff(Mod.Find<ModBuff>("DevourMark7").Type) && npc.life <= 0)
            {
                Player p = Main.player[Main.myPlayer];
                p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 600);
            }
        }

        public override void SetupTravelShop(int[] shop, ref int nextSlot)
        {
            if (Main.rand.Next(6) == 0)
            {
                shop[nextSlot] = ModContent.ItemType<Eriana1>();
                nextSlot++;
            }
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (DevourMark1)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 20;
                if (damage < 2)
                {
                    damage = 7;
                }
            }

            if (DevourMark2)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 25;
                if (damage < 2)
                {
                    damage = 8;
                }
            }

            if (DevourMark3)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 30;
                if (damage < 2)
                {
                    damage = 9;
                }
            }

            if (DevourMark3Super)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 30;
                if (damage < 2)
                {
                    damage = 12;
                }
            }

            if (DevourMark4)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 35;
                if (damage < 2)
                {
                    damage = 10;
                }
            }

            if (DevourMark4Super)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 35;
                if (damage < 2)
                {
                    damage = 13;
                }
            }

            if (DevourMark5)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 40;
                if (damage < 2)
                {
                    damage = 11;
                }
            }

            if (DevourMark5Super)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 40;
                if (damage < 2)
                {
                    damage = 14;
                }
            }

            if (DevourMark6)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 45;
                if (damage < 2)
                {
                    damage = 12;
                }
            }

            if (DevourMark6Super)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 45;
                if (damage < 2)
                {
                    damage = 15;
                }
            }

            if (DevourMark7)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 60;
                if (damage < 2)
                {
                    damage = 15;
                }
            }

            if (DevourMark7Super)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 60;
                if (damage < 2)
                {
                    damage = 30;
                }
            }
        }
    }

}