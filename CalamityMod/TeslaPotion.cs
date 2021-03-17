﻿using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class TeslaPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "TeslaPotion";
        }

        protected override string GetBuffName() {
            return "TeslaBuff";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            // Not used
        }

    }
}
