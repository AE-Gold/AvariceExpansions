using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Tokens
{
    public class EvilToken : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Evil Token");
            Tooltip.SetDefault("A small token forged from the essence of evil.");
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(0, 0, 50, 0);
            Item.rare = 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddRecipeGroup("AvariceExpansions:anyDemoniteBar", 10);
            recipe.AddRecipeGroup("AvariceExpansions:anyShadowScale", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}