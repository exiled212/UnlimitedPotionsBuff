using Terraria.ID;

namespace UnlimitedPotisBuff.Items.MagicPowerPotion {
    public class MagicPowerPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de poder mágico";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.MagicPowerPotion;
        }

        protected override int GetBuffId() {
            return BuffID.MagicPower;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
