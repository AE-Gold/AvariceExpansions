using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.Huckleberry
{
    public class Rampage : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rampage");
            Description.SetDefault("Dealing increase damage!");
            Main.debuff[Type] = true;
        }
    }
}