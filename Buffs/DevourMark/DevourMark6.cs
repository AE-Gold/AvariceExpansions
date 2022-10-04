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
	public class DevourMark6 : ModBuff
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
			player.GetModPlayer<AvariceExpansionsPlayer>().DevourMark6 = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<AvariceExpansionsGlobalNPC>().DevourMark6 = true;
			if (npc.HasBuff(Mod.Find<ModBuff>("DevourMark6").Type) && npc.life <= 0)
			{
				Player p = Main.player[Main.myPlayer];
				p.AddBuff(Mod.Find<ModBuff>("SoulDevourer").Type, 300);
			}
		}
	}
}
