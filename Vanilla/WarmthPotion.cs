using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class WarmthPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.WarmthPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Warmth;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
