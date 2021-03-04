using Terraria.ID;

namespace UnlimitedPotisBuff.Items.LifeforcePotion {
    public class LifeforcePotion : ItemBase {

        protected override string getName() {
            return "Reliquia de fuerza vital";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.LifeforcePotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Lifeforce;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
