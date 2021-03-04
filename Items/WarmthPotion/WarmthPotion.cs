using Terraria.ID;

namespace UnlimitedPotisBuff.Items.WarmthPotion {
    public class WarmthPotion : ItemBase {

        protected override string getName() {
            return "Reliquia del calor";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.WarmthPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Warmth;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
