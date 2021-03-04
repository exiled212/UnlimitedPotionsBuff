using Terraria.ID;

namespace UnlimitedPotisBuff.Items.EndurancePotion {
    public class EndurancePotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de resistencia";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.EndurancePotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Endurance;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
