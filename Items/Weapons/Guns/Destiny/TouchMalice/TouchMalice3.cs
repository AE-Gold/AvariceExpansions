using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.TouchMalice
{
    public class TouchMalice3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Touch of Malice");
            Tooltip.SetDefault("'Let them feel every touch of malice they have dealt to me.'\n[c/00A2C1:Deals damage to player in exchange for more power.]\n[c/02FF8A:Mark 3]");
        }

        public override void SetDefaults()
        {
            Item.damage = 37;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.rare = 4;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("KineticBullet").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Kinetic.KineticBullet>() });
            player.statLife -= 5;
            if (player.statLife < 0)
                player.KillMe(PlayerDeathReason.ByCustomReason(player.name + " fell victim to the Touch of Malice"), 1, 1);
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5, 0);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "FleshToken", 1);
            recipe.AddIngredient(null, "TouchMalice2", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}