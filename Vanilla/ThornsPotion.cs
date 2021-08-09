using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    class ThornsPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.ThornsPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Thorns;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
