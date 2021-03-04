using Terraria.ID;

namespace UnlimitedPotisBuff.Items.RegenerationPotion {
    public class RegenerationPotion: ItemBase {

        protected override string getName() {
            return "Reliquia de regeneración";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.RegenerationPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Regeneration;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
