using Terraria.ID;

namespace UnlimitedPotisBuff.Items.GravitationPotion {
    class GravitationPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de gravedad";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.GravitationPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Gravitation;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
