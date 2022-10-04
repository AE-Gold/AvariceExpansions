using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items
{
    public class TimeChanger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Time Changer");
            Tooltip.SetDefault("Dev Item");
        }

        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;
            Item.rare = ItemRarityID.Red;
            Item.useAnimation = 30;
            Item.useTime = 30;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.UseSound = SoundID.Item4;
            Item.consumable = false;
        }

        public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */
        {

            Main.time = 0.0f;
            Main.dayTime = !Main.dayTime;
            return true;
        }
    }
}