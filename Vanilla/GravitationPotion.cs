using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    class GravitationPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.GravitationPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Gravitation;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
