using Terraria.ID;

namespace UnlimitedPotisBuff.Items.FlipperPotion {
    public class FlipperPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de aletas";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.FlipperPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Flipper;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
