using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class SummoningPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.SummoningPotion;
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
