using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class WrathPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.WrathPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Wrath;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
