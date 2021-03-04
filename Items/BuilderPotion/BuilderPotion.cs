using Terraria.ID;

namespace UnlimitedPotisBuff.Items.BuilderPotion {
    public class BuilderPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia constructora";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.BuilderPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Builder;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
