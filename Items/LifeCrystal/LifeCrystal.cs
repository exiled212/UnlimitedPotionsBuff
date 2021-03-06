using Terraria.ID;

namespace UnlimitedPotisBuff.Items.LifeCrystal {
    class LifeCrystal : ItemBase {

        protected override string GetName() {
            return "Reliquia del corazón de cristal";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.HeartLantern;
        }

        protected override int GetBuffId() {
            return BuffID.HeartLamp;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.TinkerersWorkbench;
        }

        protected override int GetItemCount() {
            return 20;
        }

    }
}
