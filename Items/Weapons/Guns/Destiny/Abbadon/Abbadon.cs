using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Abbadon
{
    public class Abbadon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Abbadon");
            Tooltip.SetDefault("'I am your funeral pyre.'\n[c/00A2C1:Shoots faster the longer it's fired]\n[c/00A2C1:Fires solar Projectiles]");
        }

        public override void SetDefaults()
        {
            Item.damage = 45;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 1;
            Item.useAnimation = 1;
            Item.channel = true;
            Item.autoReuse = true;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = 10;
            Item.UseSound = SoundID.Item11;
            Item.shoot = Mod.Find<ModProjectile>("AbbadonSprite").Type;
            Item.useAmmo = Mod.Find<ModItem>("HeavyAmmo").Type;
            Item.shootSpeed = 16f;
            Item.crit = 0;
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] <= 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

            .AddIngredient(ItemID.FragmentVortex, 18)
            .AddIngredient(ItemID.FragmentSolar, 2)
            .AddTile(TileID.LunarCraftingStation)
            .Register();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            Projectile.NewProjectile(position, new Vector2 (velocity) , ProjectileType<Projectiles.Destiny.Abbadon.AbbadonSprite>(), damage, knockback, player.whoAmI, 0f, 0f);
        }
    }
}