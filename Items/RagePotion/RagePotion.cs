using Terraria.ID;

namespace UnlimitedPotisBuff.Items.RagePotion {
    public class RagePotion: ItemBase {

        protected override string GetName() {
            return "Reliquia de furia";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.RagePotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Rage;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
