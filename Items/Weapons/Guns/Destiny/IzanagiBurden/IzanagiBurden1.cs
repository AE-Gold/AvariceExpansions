using AvariceExpansions.Items.Tokens;
using AvariceExpansions.Projectiles.Destiny.Kinetic;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.IzanagiBurden
{
    public class IzanagiBurden1 : ModItem
    {
        private int ammocount;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Izanagi's Burden");
            Tooltip.SetDefault("Has a special right-click ability.\nLet your enemies feel the weight of your burdens.\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.damage = 200;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.knockBack = 2;
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.width = 10;
            Item.height = 10;
            Item.crit = 21;
            Item.useAmmo = 97;
            Item.noMelee = true;
            Item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()

                .AddIngredient<GolemToken>(1)
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
                Item.useTime = 72;
                Item.useAnimation = 72;
                Item.reuseDelay = 72;
            }
            else
            {
                Item.useTime = 36;
                Item.useAnimation = 36;
                Item.reuseDelay = 36;
            }

            return base.CanUseItem(player);
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            ammo.TurnToAir();

            if (player.altFunctionUse == 2)
            {
                for (ammocount = 0; ammocount < 2; ammocount++)
                {
                    player.ConsumeItem(ammo.type);
                }

                return true;
            }
            else
            {
                return true;
            }
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<KineticBullet>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15,-5);
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (player.altFunctionUse == 2)
            {
                Projectile.NewProjectileDirect(source, position, velocity, type, 900, knockback, player.whoAmI);
            }
            else
            {
                Projectile.NewProjectileDirect(source, position, velocity, type, 200, knockback, player.whoAmI);
            }
            

            return false; // Return false because we don't want tModLoader to shoot projectile
        }
    }
}