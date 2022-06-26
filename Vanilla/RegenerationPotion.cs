using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    public class RegenerationPotion: VanillaItemBase {


        protected override int GetItemId() {
            return ItemID.RegenerationPotion;
        }

        protected override int GetBuffId() {
            return BuffID.Regeneration;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
