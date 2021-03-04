using Terraria.ID;

namespace UnlimitedPotisBuff.Items.IronskinPotion {
    public class IronskinPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de piel de hierro";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.IronskinPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Ironskin;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
