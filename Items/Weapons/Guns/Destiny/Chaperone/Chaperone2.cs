using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Chaperone
{
    public class Chaperone2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chaperone");
            Tooltip.SetDefault("Let no child out of your sight\nMark 2");
        }

        public override void SetDefaults()
        {
            Item.damage = 225;
            Item.ranged = true;
            Item.width = 10;
            Item.height = 10;
            Item.useStyle = 5;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.value = Item.sellPrice(0, 5, 0, 0);
            Item.rare = 7;
            Item.UseSound = SoundID.Item36;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("ChaperoneShot").Type;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 6;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(Mod.Find<ModBuff>("Roadborn").Type))
            {
                Item.useStyle = 5;
                Item.useTime = 36;
                Item.useAnimation = 36;
                Item.damage = 300;
                Item.useAmmo = 97;
                Item.crit = 26;
                Item.UseSound = SoundID.Item36;
            }
            else
            {
                Item.useStyle = 5;
                Item.useTime = 36;
                Item.useAnimation = 36;
                Item.damage = 225;
                Item.useAmmo = 97;
                Item.crit = 6;
                Item.UseSound = SoundID.Item36;
            }

            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(null, "PlanteraToken", 1);
            recipe.AddIngredient(null, "Chaperone1", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(new int[] { ProjectileType<Projectiles.Destiny.Chaperone.ChaperoneShot>() });
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, +4);
        }
    }
}