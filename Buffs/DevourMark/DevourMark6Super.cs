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
	public class DevourMark6Super : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mark of the Devourer");
			Description.SetDefault("Taking damage from Thorn!");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<AvariceExpansionsPlayer>().DevourMark6Super = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<AvariceExpansionsGlobalNPC>().DevourMark6Super = true;
		}
	}
}
