using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items.Weapons.Guns.LC.SolemnLament
{
    public class SolemnLament : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solemn Lament");
            Tooltip.SetDefault("'Where does one go when they die?'");
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 4, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.useTime = 9;
            Item.useAnimation = 9;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 1;
            Item.scale = .8f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient(ItemID.Handgun, 2)
                .AddIngredient(ItemID.DarkShard, 1)
                .AddIngredient(ItemID.LightShard, 1)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-7, 0);
        }
    }
}