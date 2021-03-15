using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class GillsPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.GillsPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Gills;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
