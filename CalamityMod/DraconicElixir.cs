﻿using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class DraconicElixir : CalamityItemBase {

        protected override string GetItemName() {
            return "DraconicElixir";
        }

        protected override string GetBuffName() {
            return "DraconicSurgeBuff";
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
