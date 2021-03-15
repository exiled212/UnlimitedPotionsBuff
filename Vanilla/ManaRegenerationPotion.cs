using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class ManaRegenerationPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.ManaRegenerationPotion;
        }

        protected override int GetBuffId() {
            return BuffID.ManaRegeneration;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
