using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Placeable
{
    public class PAP : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pack-A-Punch");
            Tooltip.SetDefault("For a price, it can make your weapons better");
        }

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 38;
            Item.maxStack = 99;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = 1;
            Item.value = Item.sellPrice(0, 0, 0, 0);
            Item.rare = 10;
            Item.createTile = Mod.Find<ModTile>("PAPTile").Type;
            Item.consumable = true;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(Mod.Find<ModItem>("EyeToken").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("EvilToken").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("BoneToken").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("FleshToken").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("MechanicalToken").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("PlanteraToken").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("GolemToken").Type, 1);
            recipe.AddIngredient(Mod.Find<ModItem>("LunarToken").Type, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}