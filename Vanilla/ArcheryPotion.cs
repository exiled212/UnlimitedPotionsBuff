using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class ArcheryPotion: VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.ArcheryPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Archery;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }
    }
}
