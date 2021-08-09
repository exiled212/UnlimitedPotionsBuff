using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    class MiningPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.MiningPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Mining;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
