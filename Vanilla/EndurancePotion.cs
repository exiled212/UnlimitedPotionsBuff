using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class EndurancePotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.EndurancePotion;
        }

        protected override int GetBuffId() {
            return BuffID.Endurance;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
