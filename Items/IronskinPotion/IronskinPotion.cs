using Terraria.ID;

namespace UnlimitedPotisBuff.Items.IronskinPotion {
    public class IronskinPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de piel de hierro";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.IronskinPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Ironskin;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
