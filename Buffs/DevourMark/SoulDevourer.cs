using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.DevourMark
{
    public class SoulDevourer : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Devourer");
            Description.SetDefault("Increasing Thorn's Mark Damage!");
            Main.debuff[Type] = true;
        }
    }
}