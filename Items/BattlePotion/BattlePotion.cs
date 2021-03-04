using Terraria.ID;

namespace UnlimitedPotisBuff.Items.BattlePotion {
    public class BattlePotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de batalla";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.BattlePotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Battle;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
