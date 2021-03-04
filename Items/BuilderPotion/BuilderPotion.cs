using Terraria.ID;

namespace UnlimitedPotisBuff.Items.BuilderPotion {
    public class BuilderPotion : ItemBase {

        protected override string getName() {
            return "Reliquia constructora";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.BuilderPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Builder;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
