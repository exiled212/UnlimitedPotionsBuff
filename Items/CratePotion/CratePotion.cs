using Terraria.ID;

namespace UnlimitedPotisBuff.Items.CratePotion {
    class CratePotion : ItemBase {
        protected override string GetName() {
            return "Reliquia de caja";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.CratePotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Crate;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
