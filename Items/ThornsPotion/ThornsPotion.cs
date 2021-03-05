using Terraria.ID;

namespace UnlimitedPotisBuff.Items.ThornsPotion {
    class ThornsPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de espinas";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.ThornsPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Thorns;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
