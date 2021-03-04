using Terraria.ID;

namespace UnlimitedPotisBuff.Items.GillsPotion {
    public class GillsPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de agallas";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.GillsPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Gills;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
