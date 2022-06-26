using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class BuilderPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.BuilderPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Builder;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
