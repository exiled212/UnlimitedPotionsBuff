using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Vanilla;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class GravityNormalizerPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "GravityNormalizerPotion";
        }

        protected override string GetBuffName() {
            return "GravityNormalizerBuff";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            recipe.AddIngredient(ItemType<GravitationPotion>(), 1);
        }

    }
}
