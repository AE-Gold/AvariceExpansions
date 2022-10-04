using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items.Weapons.Swords.LC.Mimicry
{
    public class Mimicry : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mimicry");
            Tooltip.SetDefault("'HELLO?\nGOODBYE.'\n[c/D50000:Heals 5 health per hit.]");
        }

        public override void SetDefaults()
        {
            Item.damage = 300;
            Item.DamageType = DamageClass.Melee;
            Item.width = 74;
            Item.height = 88;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 6;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FragmentSolar, 18)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            int healingAmount = 5;
            player.statLife += healingAmount;
            player.HealEffect(healingAmount, true);
        }
    }
}