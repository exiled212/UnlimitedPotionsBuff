using Terraria.ID;

namespace UnlimitedPotisBuff.Items.SwiftnessPotion {
    public class SwiftnessPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de rapidez";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.SwiftnessPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Swiftness;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
