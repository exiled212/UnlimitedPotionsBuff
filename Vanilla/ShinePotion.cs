using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class ShinePotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.ShinePotion;
        }

        protected override int GetBuffId() {
            return BuffID.Shine;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
