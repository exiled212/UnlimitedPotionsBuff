using Terraria.ID;

namespace UnlimitedPotisBuff.Items.ShinePotion {
    public class ShinePotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de brillo";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.ShinePotion;
        }

        protected override int GetBuffId() {
            return BuffID.Shine;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
