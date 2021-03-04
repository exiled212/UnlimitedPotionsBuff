using Terraria.ID;

namespace UnlimitedPotisBuff.Items.DangersensePotion {
    class DangersensePotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de sentido del peligro";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.TrapsightPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Dangersense;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
