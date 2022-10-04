using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.SweetBusiness
{
    public class SweetBusiness1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sweet Business");
            Tooltip.SetDefault("'...I love my job.'\n[c/00A2C1:Shoots faster the longer it's fired]\n[c/02FF8A:Mark 1]");
        }

        public override void SetDefaults()
        {
            Item.damage = 4;
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
            Item.value = Item.sellPrice(0, 2, 50, 0);
            Item.rare = 2;
            //Item.UseSound = SoundID.Item11;
            Item.shoot = Mod.Find<ModProjectile>("SweetBusinessSprite").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = -3;
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] <= 0;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "BoneToken", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position, new Vector2(speedX, speedY), ProjectileType<Projectiles.Destiny.SweetBusiness.SweetBusinessSprite>(), damage, knockBack, player.whoAmI, 0f, 0f);
            return false;
        }
    }
}