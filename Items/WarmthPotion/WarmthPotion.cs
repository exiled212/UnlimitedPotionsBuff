using Terraria.ID;

namespace UnlimitedPotisBuff.Items.WarmthPotion {
    public class WarmthPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia del calor";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.WarmthPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Warmth;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
