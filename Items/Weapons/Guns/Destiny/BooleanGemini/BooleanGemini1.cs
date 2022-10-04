using AvariceExpansions.Projectiles.Destiny.BooleanGemini;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.BooleanGemini
{
    public class BooleanGemini1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boolean Gemini");
            Tooltip.SetDefault("Fight your way!\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 1, 50, 0);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item41;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.shootSpeed = 16f;
            Item.crit = 0;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<BooleanBullet1>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-16, 0);
        }      
    }
}