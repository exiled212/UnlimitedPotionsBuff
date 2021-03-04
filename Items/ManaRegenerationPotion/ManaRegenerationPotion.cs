using Terraria.ID;

namespace UnlimitedPotisBuff.Items.ManaRegenerationPotion {
    public class ManaRegenerationPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de regeneración de maná";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.ManaRegenerationPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.ManaRegeneration;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
