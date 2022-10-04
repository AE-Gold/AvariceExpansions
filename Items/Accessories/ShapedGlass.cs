using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Accessories
{
    public class ShapedGlass : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shaped Glass");
            Tooltip.SetDefault("Double the damage at half the health!");
        }

        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;
            Item.value = Item.sellPrice(0, 0, 50, 0);
            Item.rare = 1;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 /= 2;
            player.allDamage *= 2;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.SandBlock, 999);
            recipe.AddTile(TileID.GlassKiln);
            recipe.Register();
        }
    }
}