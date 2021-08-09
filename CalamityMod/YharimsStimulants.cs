using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Vanilla;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class YharimsStimulants : CalamityItemBase {

        protected override string GetItemName() {
            return "YharimsStimulants";
        }

        protected override string GetBuffName() {
            return "YharimPower";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void AddIngredients(ModRecipe recipe) {
            recipe.AddIngredient(ItemType<EndurancePotion>(), 1);
            recipe.AddIngredient(ItemType<IronskinPotion>(), 1);
            recipe.AddIngredient(ItemType<SwiftnessPotion>(), 1);
            recipe.AddIngredient(ItemType<ArcheryPotion>(), 1);
            recipe.AddIngredient(ItemType<MagicPowerPotion>(), 1);
            recipe.AddIngredient(ItemType<TitanPotion>(), 1);
        }
    }
}
