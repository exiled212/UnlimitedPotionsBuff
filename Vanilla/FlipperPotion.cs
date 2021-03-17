using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class FlipperPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.FlipperPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Flipper;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
