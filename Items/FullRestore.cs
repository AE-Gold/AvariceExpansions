using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items
{
    public class FullRestore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Full Restore");
            Tooltip.SetDefault("Dev Item");
        }

        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;
            Item.rare = 10;
            Item.useAnimation = 30;
            Item.useTime = 30;
            Item.useStyle = 4;
            Item.UseSound = SoundID.Item4;
            Item.healLife = 999;
            Item.healMana = 999;
            Item.consumable = false;
        }
    }
}
