using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.FirstCurse
{
    public class FirstCurseBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The First Curse");
            Description.SetDefault("Consecutive hits increase damage.");
            Main.debuff[Type] = true;
        }
    }
}