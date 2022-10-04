using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.Eriana
{
    public class DeathGlance : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Death at First Glance");
            Description.SetDefault("Bonus damage, refreshes on crits\nRefreshes automatically after 4 seconds");
            Main.debuff[Type] = true;
        }
    }
}