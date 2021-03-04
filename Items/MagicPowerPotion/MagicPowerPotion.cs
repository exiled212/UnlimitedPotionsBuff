using Terraria.ID;

namespace UnlimitedPotisBuff.Items.MagicPowerPotion {
    public class MagicPowerPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de poder mágico";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.MagicPowerPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.MagicPower;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
