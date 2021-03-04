using Terraria.ID;

namespace UnlimitedPotisBuff.Items.RegenerationPotion {
    public class RegenerationPotion: ItemBase {

        protected override string GetName() {
            return "Reliquia de regeneración";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.RegenerationPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Regeneration;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
