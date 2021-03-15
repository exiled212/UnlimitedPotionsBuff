using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    class DangersensePotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.TrapsightPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Dangersense;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
