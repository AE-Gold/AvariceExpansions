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
    public class SturmBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm and Stress");
            Description.SetDefault("Sturm is getting bonus damage!");
            Main.debuff[Type] = true;
        }
    }
}