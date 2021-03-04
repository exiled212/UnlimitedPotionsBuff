using Terraria.ID;

namespace UnlimitedPotisBuff.Items.EndurancePotion {
    public class EndurancePotion : ItemBase {

        protected override string getName() {
            return "Reliquia de resistencia";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.EndurancePotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Endurance;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
