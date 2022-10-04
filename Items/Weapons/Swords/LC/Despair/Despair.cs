using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items.Weapons.Swords.LC.Despair
{
    public class Despair : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sword Sharpened by Tears");
            Tooltip.SetDefault("'Foul play is strictly forbidden.'");
        }

        public override void SetDefaults()
        {
            Item.damage = 100;
            Item.DamageType = DamageClass.Melee;
            Item.width = 78;
            Item.height = 78;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(0, 5, 50, 0);
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 6;
        }
    }
}