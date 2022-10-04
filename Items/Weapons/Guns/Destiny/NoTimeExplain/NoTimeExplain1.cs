using AvariceExpansions.Projectiles.Destiny.Kinetic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.NoTimeExplain
{
    public class NoTimeExplain1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("No Time to Explain");
            Tooltip.SetDefault("Soon.\nMark 1\n[c/D50000:You shouldn't be here!!]");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 4;
            Item.useAnimation = 12;
            Item.reuseDelay = 14;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item31;
            Item.autoReuse = true;
            Item.useAmmo = 97;
            Item.crit = -2;
            Item.shootSpeed = 16f;
            Item.scale = .85f;
            Item.consumeAmmoOnLastShotOnly = true;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<KineticBullet>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, 0);
        }
    }
}