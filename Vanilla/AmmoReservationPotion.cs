using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class AmmoReservationPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.AmmoReservationPotion;
        }

        protected override int GetBuffId() {
            return BuffID.AmmoReservation;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }
    }
}
