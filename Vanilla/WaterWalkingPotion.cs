using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    class WaterWalkingPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.WaterWalkingPotion;
        }

        protected override int GetBuffId() {
            return BuffID.WaterWalking;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
