using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    class CratePotion : VanillaItemBase {
        protected override int GetItemId() {
            return ItemID.CratePotion;
        }

        protected override int GetBuffId() {
            return BuffID.Crate;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
