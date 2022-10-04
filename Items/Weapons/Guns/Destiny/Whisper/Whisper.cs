using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AvariceExpansions.Projectiles.Destiny.Whisper;

namespace AvariceExpansions.Items.Weapons.Guns.Destiny.Whisper
{
    public class Whisper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Whisper of the Worm");
            Tooltip.SetDefault("'A Terrarian's power makes a rich feeding ground. Do not be revolted.\nThere are parasites that may benefit the host... teeth sharper than your own.'\n[c/00A2C1:Critical Hits refund ammunition]");
        }

        public override void SetDefaults()
        {
            Item.damage = 750;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 1;
            Item.value = Item.sellPrice(0, 10, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item40;
            Item.autoReuse = true;
            Item.useAmmo = Mod.Find<ModItem>("HeavyAmmo").Type;
            Item.shootSpeed = 16f;
            Item.crit = 31;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            type = ProjectileType<WhisperBullet>();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, -5);
        }
    }
}