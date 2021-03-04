using Terraria.ID;

namespace UnlimitedPotisBuff.Items.GillsPotion {
    public class GillsPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de agallas";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.GillsPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Gills;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
