using Terraria.ID;

namespace UnlimitedPotisBuff.Items.FireHeartCrystal {
    class FireHeartCrystal : ItemBase {

        protected override string GetName() {
            return "Reliquia del corazón de fuego";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.LifeCrystal;
        }

        protected override int GetBuffId() {
            return BuffID.Campfire;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.Campfire;
        }

        protected override int GetItemCount() {
            return 20;
        }

    }
}
