using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.SturmDrang
{
    public class DrangBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Together Forever");
            Description.SetDefault("Faster fire rate for Drang!");
            Main.debuff[Type] = true;
        }
    }
}