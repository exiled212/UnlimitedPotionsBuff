using Terraria.ID;

namespace UnlimitedPotisBuff.Items.HeartreachPotion {
    public class HeartreachPotion : ItemBase {
        protected override string getName() {
            return "Reliquia alcanzacorazón";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.HeartreachPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Heartreach;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
