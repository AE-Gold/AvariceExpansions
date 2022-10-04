using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions;

namespace AvariceExpansions.Buffs.Suppressed
{
    public class TCSuppressed2 : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Suppressed");
            Description.SetDefault("Taking 100% more damage");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            longerExpertDebuff = false;
        }
    }

    public class SuppressedEffect2TC : GlobalNPC
    {
        public override void ModifyHitByProjectile(NPC npc, Projectile Projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (npc.HasBuff(Mod.Find<ModBuff>("TCSuppressed2").Type))
            {
                damage = (int)(damage * 2f);
            }
        }
        public override void ModifyHitByItem(NPC npc, Player player, Item Item, ref int damage, ref float knockback, ref bool crit)
        {
            if (npc.HasBuff(Mod.Find<ModBuff>("TCSuppressed2").Type))
            {
                damage = (int)(damage * 2f);
            }
        }
    }
}