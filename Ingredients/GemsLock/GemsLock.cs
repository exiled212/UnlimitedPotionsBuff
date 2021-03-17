using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotionsBuffs.Ingredients.GemsLock {
    class GemsLock : ModItem {

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Adorno de gemas");
            Tooltip.SetDefault("Un adorno creado con todas las gemas grandes, contiene un misterioso poder.");
        }

        public override void SetDefaults() {
            item.width = 70;
            item.height = 70;
            item.value = Item.sellPrice(gold: 20);
            item.rare = ItemRarityID.Blue;
            item.maxStack = 99;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LargeAmber, 1);
            recipe.AddIngredient(ItemID.LargeAmethyst, 1);
            recipe.AddIngredient(ItemID.LargeDiamond, 1);
            recipe.AddIngredient(ItemID.LargeEmerald, 1);
            recipe.AddIngredient(ItemID.LargeRuby, 1);
            recipe.AddIngredient(ItemID.LargeSapphire, 1);
            recipe.AddIngredient(ItemID.LargeTopaz, 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
