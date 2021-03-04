using Terraria.ID;

namespace UnlimitedPotisBuff.Items.HunterPotion {
    class HunterPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de cazador";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.HunterPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Hunter;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
