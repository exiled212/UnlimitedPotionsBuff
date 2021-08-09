using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class IronskinPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.IronskinPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Ironskin;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
