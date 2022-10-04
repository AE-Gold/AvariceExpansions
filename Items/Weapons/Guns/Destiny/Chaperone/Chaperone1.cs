using AvariceExpansions.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Chaperone
{
    public class Chaperone1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chaperone");
            Tooltip.SetDefault("Let no child out of your sight\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 150;
            Item.width = 10;
            Item.height = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.value = Item.sellPrice(0, 4, 0, 0);
            Item.rare = ItemRarityID.Pink;
            Item.UseSound = SoundID.Item36;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 6;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(BuffType<Roadborn>()))
            {
                Item.damage = 200;
                Item.crit = 21;
            }
            else
            {
                Item.damage = 150;
                Item.crit = 6;
            }

            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.HallowedBar, 3)
                .AddIngredient(ItemID.Wood, 3)
                .AddIngredient(ItemID.IllegalGunParts, 1)
                .AddRecipeGroup("IronBar", 20)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient(ItemID.SoulofFright, 10)
                .AddIngredient(ItemID.SoulofSight, 10)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Chaperone.ChaperoneShot>() });
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, +4);
        }
    }
}