using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.MonteCarlo
{
    public class MonteCarlo6 : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Increased Damage");
            Description.SetDefault("Gaining more damage from\nMonte Carlo!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 4f;
        }
    }
}