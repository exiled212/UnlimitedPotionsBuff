using Terraria.ID;

namespace UnlimitedPotisBuff.Items.RagePotion {
    public class RagePotion: ItemBase {

        protected override string getName() {
            return "Reliquia de furia";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.RagePotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Rage;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
