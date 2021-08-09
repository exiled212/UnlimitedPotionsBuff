using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Vanilla;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class TitanScalePotion : CalamityItemBase {

        protected override string GetItemName() {
            return "TitanScalePotion";
        }

        protected override string GetBuffName() {
            return "TitanScale";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            recipe.AddIngredient(ItemType<TitanPotion>(), 1);
        }
    }
}
