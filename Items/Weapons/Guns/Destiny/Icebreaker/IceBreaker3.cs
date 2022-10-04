﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Icebreaker;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Icebreaker
{
    public class Icebreaker3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Breaker");
            Tooltip.SetDefault("Replace operator if use causes fatal damage.\nMark 3");
        }

        public override void SetDefaults()
        {
            Item.damage = 90;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 66;
            Item.useAnimation = 66;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.shootSpeed = 16f;
            Item.crit = 16;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<Icebreaker2>(1)
                .AddIngredient<EvilToken>(1)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<IceBBullet>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, -3);
        }
    }
}