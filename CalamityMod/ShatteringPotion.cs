using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class ShatteringPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "ShatteringPotion";
        }

        protected override string GetBuffName() {
            return "ArmorShattering";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            // Not used
        }

    }
}
