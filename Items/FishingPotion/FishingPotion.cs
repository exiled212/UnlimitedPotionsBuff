using Terraria.ID;

namespace UnlimitedPotisBuff.Items.FishingPotion {
    class FishingPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de pesca";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.FishingPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Fishing;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
