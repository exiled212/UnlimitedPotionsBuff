using Terraria.ID;

namespace UnlimitedPotisBuff.Items.AmmoReservationPotion {
    public class AmmoReservationPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de reserva de munición";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.AmmoReservationPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.AmmoReservation;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
