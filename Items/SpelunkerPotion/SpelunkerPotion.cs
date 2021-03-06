using Terraria.ID;

namespace UnlimitedPotisBuff.Items.SpelunkerPotion {
    class SpelunkerPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de espeleólogo";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.SpelunkerPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Spelunker;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
