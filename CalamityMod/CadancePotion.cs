using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Vanilla;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class CadancePotion : CalamityItemBase {

        protected override string GetItemName() {
            return "CadencePotion";
        }

        protected override string GetBuffName() {
            return "Cadence";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            recipe.AddIngredient(ItemType<HeartreachPotion>(), 1);
            recipe.AddIngredient(ItemType<LifeforcePotion>(), 1);
            recipe.AddIngredient(ItemType<RegenerationPotion>(), 1);
        }
    }
}
