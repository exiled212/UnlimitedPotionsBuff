using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    class SonarPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.SonarPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Sonar;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
