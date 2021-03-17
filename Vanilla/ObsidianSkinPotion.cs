using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.Vanilla {
    class ObsidianSkinPotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.ObsidianSkinPotion;
        }

        protected override int GetBuffId() {
            return BuffID.ObsidianSkin;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
