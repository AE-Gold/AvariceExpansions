﻿using System;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AvariceExpansions.Items.Tokens
{
    public class BoneToken : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boney Token");
            Tooltip.SetDefault("A small token foraged from the dead Skeleton.");
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(0, 0, 75, 0);
            Item.rare = 2;
        }
    }
}