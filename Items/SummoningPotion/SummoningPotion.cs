using Terraria.ID;

namespace UnlimitedPotisBuff.Items.SummoningPotion {
    public class SummoningPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de invocación";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.SummoningPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Summoning;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
