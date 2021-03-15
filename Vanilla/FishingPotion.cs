using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    class FishingPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.FishingPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Fishing;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
