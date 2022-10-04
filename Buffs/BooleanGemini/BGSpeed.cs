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
    public class BGSpeed : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("One Way");
            Description.SetDefault("Increasing Speed");
            Main.debuff[Type] = true;
        }
    }
}