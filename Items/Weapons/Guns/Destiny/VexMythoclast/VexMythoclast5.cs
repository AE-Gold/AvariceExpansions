﻿using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.VexMythoclast;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.VexMythoclast
{
    public class VexMythoclast5 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vex Mythoclast");
            Tooltip.SetDefault("Alters the very nature of space and time\nMark 5");
        }

        public override void SetDefaults()
        {
            Item.damage = 180;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item12;
            Item.autoReuse = true;
            Item.mana = 10;
            Item.shootSpeed = 16f;
            Item.crit = 24;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<VexMythoclastH>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<VexMythoclast4>(1)
                .AddIngredient<GolemToken>(1)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5, -2);
        }
    }
}