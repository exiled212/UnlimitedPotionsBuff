using Terraria.ID;

namespace UnlimitedPotisBuff.Items.WrathPotion {
    public class WrathPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de ira";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.WrathPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Wrath;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
