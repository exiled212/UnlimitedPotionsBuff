using Terraria.ID;

namespace UnlimitedPotisBuff.Items.SwiftnessPotion {
    public class SwiftnessPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de rapidez";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.SwiftnessPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Swiftness;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
