using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class RagePotion: VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.RagePotion;
        }

        protected override int GetBuffId() {
            return BuffID.Rage;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
