using Terraria.ID;

namespace UnlimitedPotisBuff.Items.ManaRegenerationPotion {
    public class ManaRegenerationPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de regeneración de maná";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.ManaRegenerationPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.ManaRegeneration;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
