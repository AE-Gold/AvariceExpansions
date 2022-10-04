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
	public class DevourMark3 : ModBuff
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
			player.GetModPlayer<AvariceExpansionsPlayer>().DevourMark3 = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<AvariceExpansionsGlobalNPC>().DevourMark3 = true;
			if (npc.HasBuff(Mod.Find<ModBuff>("DevourMark3").Type) && npc.life <= 0)
			{
				Player p = Main.player[Main.myPlayer];
				p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 300);
			}
		}
	}
}
