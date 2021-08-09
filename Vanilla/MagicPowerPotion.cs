using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class MagicPowerPotion : VanillaItemBase {

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
