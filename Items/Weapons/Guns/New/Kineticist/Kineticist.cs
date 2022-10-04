using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.New.Kineticist
{
    public class Kineticist : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Kineticist");
            Tooltip.SetDefault("'Hell. It's about time.'\n[c/00A2C1:Shoots faster the longer it's fired]");
        }

        public override void SetDefaults()
        {
            Item.damage = 75;
            Item.ranged = true;
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
            Item.shoot = Mod.Find<ModProjectile>("KineticistSprite").Type;
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
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.FragmentVortex, 18);
            recipe.AddIngredient(ItemID.FragmentStardust, 2);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position, new Vector2(speedX, speedY), ProjectileType<Projectiles.New.Kineticist.KineticistSprite>(), damage, knockBack, player.whoAmI, 0f, 0f);
            return false;
        }
    }
}