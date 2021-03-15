using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    class NightOwlPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.NightOwlPotion;
        }

        protected override int GetBuffId() {
            return BuffID.NightOwl;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
