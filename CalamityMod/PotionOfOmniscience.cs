using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Vanilla;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class PotionOfOmniscience : CalamityItemBase {

        protected override string GetItemName() {
            return "PotionofOmniscience";
        }

        protected override string GetBuffName() {
            return "Omniscience";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            recipe.AddIngredient(ItemType<HunterPotion>(), 1);
            recipe.AddIngredient(ItemType<SpelunkerPotion>(), 1);
            recipe.AddIngredient(ItemType<DangersensePotion>(), 1);
        }
    }
}
