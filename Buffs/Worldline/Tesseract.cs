using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.Worldline
{
	public class Tesseract : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tesseract Recharging");
			Description.SetDefault("");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			longerExpertDebuff = false;
		}
	}
}
