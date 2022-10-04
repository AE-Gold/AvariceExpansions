using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace AvariceExpansions
{
	class AvariceExpansions : Mod
	{
		public AvariceExpansions()
		{
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold Bar", new int[]
            {
                    ItemID.PlatinumBar,
                    ItemID.GoldBar
            });
            RecipeGroup.RegisterGroup("AvariceExpansions:anyGoldBar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Bar", new int[]
            {
                ItemID.DemoniteBar,
                ItemID.CrimtaneBar
            });
            RecipeGroup.RegisterGroup("AvariceExpansions:anyDemoniteBar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Material", new int[]
            {
                ItemID.ShadowScale,
                ItemID.TissueSample
            });
            RecipeGroup.RegisterGroup("AvariceExpansions:anyShadowScale", group);
        }
    }
}