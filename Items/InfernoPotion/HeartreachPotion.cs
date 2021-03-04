using Terraria.ID;

namespace UnlimitedPotisBuff.Items.InfernoPotion {
    public class InfernoPotion : ItemBase {

        protected override string getName() {
            return "Reliquia del infierno";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.InfernoPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Inferno;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
