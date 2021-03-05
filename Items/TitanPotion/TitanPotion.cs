using Terraria.ID;

namespace UnlimitedPotisBuff.Items.TitanPotion {
    public class TitanPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de titán";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.TitanPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Titan;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
