using Terraria.ID;

namespace UnlimitedPotisBuff.Items.AmmoReservationPotion {
    public class AmmoReservationPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de reserva de munición";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.AmmoReservationPotion; ;
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
