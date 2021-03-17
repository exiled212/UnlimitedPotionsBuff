using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class RevivifyPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "RevivifyPotion";
        }

        protected override string GetBuffName() {
            return "Revivify";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            // Not implement
        }

    }
}
