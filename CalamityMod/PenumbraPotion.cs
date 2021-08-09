using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class PenumbraPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "PenumbraPotion";
        }

        protected override string GetBuffName() {
            return "PenumbraBuff";
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
