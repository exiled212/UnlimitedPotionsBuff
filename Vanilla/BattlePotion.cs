using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class BattlePotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.BattlePotion;
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
