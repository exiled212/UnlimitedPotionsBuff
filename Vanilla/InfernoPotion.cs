using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class InfernoPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.InfernoPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Inferno;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
