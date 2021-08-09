using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Vanilla;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotionsBuffs.CalamityMod {
    class HolyWrathPotion : CalamityItemBase {

        protected override string GetItemName() {
            return "HolyWrathPotion";
        }

        protected override string GetBuffName() {
            return "HolyWrathBuff";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }
        
        protected override void AddIngredients(ModRecipe recipe) {
            recipe.AddIngredient(ItemType<WrathPotion>(), 1);
        }

    }
}
