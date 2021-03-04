using Terraria.ID;

namespace UnlimitedPotisBuff.Items.ArcheryPotion {
    public class ArcheryPotion: ItemBase {

        protected override string GetName() {
            return "Reliquia de arquero";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.ArcheryPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Archery;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }
    }
}
