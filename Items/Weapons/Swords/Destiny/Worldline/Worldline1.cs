using AvariceExpansions.Buffs.Worldline;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AvariceExpansions.Items.Weapons.Swords.Destiny.Worldline
{
    public class Worldline1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Worldline Zero");
            Tooltip.SetDefault("'A single strike can alter the course of history'\n[c/00A2C1:Right click to teleport]\n[c/00A2C1:20 second cooldown]\n[c/02FF8A:Mark 1]");
        }

        public override void SetDefaults()
        {
            Item.damage = 70;
            Item.DamageType = DamageClass.Melee;
            Item.width = 76;
            Item.height = 78;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 10;
            Item.value = Item.sellPrice(0, 4, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.autoReuse = true;
            Item.crit = 6;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient(ItemID.Excalibur, 1)
                .AddIngredient(ItemID.RodofDiscord, 1)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                Item.UseSound = SoundID.Item8;

                if (player.HasBuff(ModContent.BuffType<Tesseract>()))
                {
                    return false;
                }

                else if(!Collision.SolidCollision(Main.MouseWorld, player.width, player.height))
                {
                    player.position = Main.MouseWorld;
                    player.AddBuff(ModContent.BuffType<Tesseract>(), 1200);
                }
            }

            else
            {
                Item.UseSound = SoundID.Item1;
            }

            return base.CanUseItem(player);
        }
    }
}