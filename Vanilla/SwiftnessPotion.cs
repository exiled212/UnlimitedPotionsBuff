using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class SwiftnessPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.SwiftnessPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Swiftness;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
