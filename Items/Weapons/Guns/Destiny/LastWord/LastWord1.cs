using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AvariceExpansions.Projectiles.Destiny.Kinetic;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.LastWord
{
    public class LastWord1 : ModItem
	{
        private int ammocount;

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault ("The Last Word");
			Tooltip.SetDefault ("'Yours, not mine.'\n[c/00A2C1:Has a special right-click ability.]\n[c/02FF8A:Mark 1]");
		}
		
		public override void SetDefaults()
		{
			Item.damage = 42;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = ItemUseStyleID.Shoot;
			Item.value = Item.sellPrice(0, 4, 0 , 0);
			Item.knockBack = 2;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item40;
			Item.autoReuse = true;
			Item.width = 10;
			Item.height = 10;
			Item.crit = 6;
			Item.useAmmo = 97;
			Item.noMelee = true;
            Item.shootSpeed = 16f;
            Item.scale = .9f;
		}
        public override void AddRecipes()
		{
            CreateRecipe()


                .AddIngredient (ItemID.HallowedBar, 10)
			    .AddIngredient (ItemID.Wood, 5)
			    .AddIngredient (ItemID.IllegalGunParts, 1)
			    .AddRecipeGroup("IronBar", 5)
			    .AddIngredient (ItemID.SoulofMight, 10)
			    .AddTile (TileID.MythrilAnvil)
			    .Register ();
		}
        
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                Item.useTime = 3;
                Item.useAnimation = 18;
                Item.reuseDelay = 18;
            }
            else
            {
                Item.useTime = 7;
                Item.useAnimation = 7;
                Item.reuseDelay = 7;
            }

            return base.CanUseItem(player);
        }

        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            ammo.TurnToAir();
            
            if (player.altFunctionUse == 2)
            {
                for (ammocount = 0; ammocount < 4; ammocount++)
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

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (player.altFunctionUse == 2)
            {
                Projectile.NewProjectileDirect(source, position, velocity, type, 8, knockback, player.whoAmI);
            }
            else
            {
                Projectile.NewProjectileDirect(source, position, velocity, type, damage, knockback, player.whoAmI);
            }


            return false;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(5, 1);
        }
    }
}