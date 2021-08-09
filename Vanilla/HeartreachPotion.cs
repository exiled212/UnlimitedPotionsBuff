using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class HeartreachPotion : VanillaItemBase {
        protected override int GetItemId() {
            return ItemID.HeartreachPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Heartreach;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
