using Terraria.ID;

namespace UnlimitedPotisBuff.Items.ArcheryPotion {
    public class ArcheryPotion: ItemBase {

        protected override string getName() {
            return "Reliquia de arquero";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.ArcheryPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Archery;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }
    }
}
