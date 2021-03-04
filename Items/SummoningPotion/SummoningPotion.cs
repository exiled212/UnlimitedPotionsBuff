using Terraria.ID;

namespace UnlimitedPotisBuff.Items.SummoningPotion {
    public class SummoningPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de invocación";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.SummoningPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Summoning;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
