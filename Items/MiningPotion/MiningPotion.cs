using Terraria.ID;

namespace UnlimitedPotisBuff.Items.MiningPotion {
    class MiningPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de minería";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.MiningPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Mining;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
