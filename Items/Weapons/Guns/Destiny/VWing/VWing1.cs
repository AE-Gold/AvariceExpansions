using AvariceExpansions.Projectiles.Destiny.Kinetic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.VWing
{
    public class VWing1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vigilance Wing");
            Tooltip.SetDefault("The lighthouse remains lit.\nMark 1");
        }

        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 3;
            Item.useAnimation = 15;
            Item.reuseDelay = 16;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item31;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = -2;
            Item.shootSpeed = 16f;
            Item.consumeAmmoOnLastShotOnly = true;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<KineticBullet>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-13, 0);
        }
    }
}