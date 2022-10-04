using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs
{
    public class Roadborn : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Roadborn");
            Description.SetDefault("Increased crit chance and damage\n(Chaperone)");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            longerExpertDebuff = false;
        }
    }
}