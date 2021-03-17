using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    class SpelunkerPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.SpelunkerPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Spelunker;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
