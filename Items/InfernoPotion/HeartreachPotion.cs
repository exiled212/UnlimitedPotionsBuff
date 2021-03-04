using Terraria.ID;

namespace UnlimitedPotisBuff.Items.InfernoPotion {
    public class InfernoPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia del infierno";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.InfernoPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Inferno;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
