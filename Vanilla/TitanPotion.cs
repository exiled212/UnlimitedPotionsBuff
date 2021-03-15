using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class TitanPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.TitanPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Titan;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
