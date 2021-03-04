using Terraria.ID;

namespace UnlimitedPotisBuff.Items.WaterWalkingPotion {
    class WaterWalkingPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de flotación";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.WaterWalkingPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.WaterWalking;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
