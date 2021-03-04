using Terraria.ID;

namespace UnlimitedPotisBuff.Items.SonarPotion {
    class SonarPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de sonar";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.SonarPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Sonar;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
