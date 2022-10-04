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
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Items.Weapons.Guns.Destiny;
using AvariceExpansions.Items.Weapons.Guns.Destiny.Hardlight;
using AvariceExpansions.Items.Weapons.Guns.Destiny.MonteCarlo;
using AvariceExpansions.Items.Weapons.Guns.Destiny.LordWolves;
using AvariceExpansions.Items.Weapons.Guns.Destiny.Hawkmoon;
using AvariceExpansions.Items.Accessories.LCorp;
using AvariceExpansions;

namespace AvariceExpansions.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag)
            {
                if (Main.rand.Next(8) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("Hardlight1").Type, 1);
                if (Main.rand.Next(8) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("LordWolves1").Type, 1);
                if (Main.rand.Next(100) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("Heart").Type, 1);
                player.QuickSpawnItem(Mod.Find<ModItem>("FleshToken").Type, 2);
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(20, 30));
            }

            if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag)
            {
                if (Main.rand.Next(8) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("FabianStrategy1").Type);
                player.QuickSpawnItem(Mod.Find<ModItem>("EyeToken").Type, 2);
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(5, 10));
            }

            if (context == "bossBag" && arg == ItemID.SkeletronBossBag)
            {
                if (Main.rand.Next(8) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("MonteCarlo1").Type, 1);
                if (Main.rand.Next(8) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("SweetBusiness1").Type, 1);
                if (Main.rand.Next(8) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("Hawkmoon1").Type, 1);
                player.QuickSpawnItem(Mod.Find<ModItem>("BoneToken").Type, 2);
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(15, 20));
            }

            if (context == "bossBag" && arg == ItemID.GolemBossBag)
            {
                player.QuickSpawnItem(Mod.Find<ModItem>("GolemToken").Type, 2);
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(50, 75));
            }

            if (context == "bossBag" && arg == ItemID.PlanteraBossBag)
            {
                player.QuickSpawnItem(Mod.Find<ModItem>("PlanteraToken").Type, 2);
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(40, 50));
            }

            if (context == "bossBag" && arg == ItemID.MoonLordBossBag)
            {
                if (Main.rand.Next(8) == 0)
                    player.QuickSpawnItem(Mod.Find<ModItem>("Whisper").Type, 1);
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, 200);
            }

            if (context == "bossBag" && (arg == ItemID.BrainOfCthulhuBossBag || arg == ItemID.EaterOfWorldsBossBag))
            {
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(10, 15));
            }

            if (context == "bossBag" && (arg == ItemID.SkeletronPrimeBossBag || arg == ItemID.TwinsBossBag || arg == ItemID.DestroyerBossBag))
            {
                player.QuickSpawnItem(Mod.Find<ModItem>("HeavyAmmo").Type, Main.rand.Next(30, 40));
            }
        }
    }
}