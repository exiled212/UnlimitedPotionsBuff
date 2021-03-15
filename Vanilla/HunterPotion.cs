using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    class HunterPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.HunterPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Hunter;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
