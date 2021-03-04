using Terraria.ID;

namespace UnlimitedPotisBuff.Items.TitanPotion {
    public class TitanPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de titán";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.TitanPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Titan;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
