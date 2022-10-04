using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.BooleanGemini
{
    public class BGDefense : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Or Another");
            Description.SetDefault("Increasing Defense");
            Main.debuff[Type] = true;
        }
    }
}