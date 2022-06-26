using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotionsBuffs.Ingredients.GemsLock {
    class GemsLock : ModItem {

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ópalo");
            Tooltip.SetDefault("Esta gema se puede usar de catalizador para solidificar sustancias químicas.");
        }

        public override void SetDefaults() {
            Item.width = 70;
            Item.height = 70;
            Item.value = Item.sellPrice(gold: 20);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 99;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LargeAmber, 1);
            recipe.AddIngredient(ItemID.LargeAmethyst, 1);
            recipe.AddIngredient(ItemID.LargeDiamond, 1);
            recipe.AddIngredient(ItemID.LargeEmerald, 1);
            recipe.AddIngredient(ItemID.LargeRuby, 1);
            recipe.AddIngredient(ItemID.LargeSapphire, 1);
            recipe.AddIngredient(ItemID.LargeTopaz, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.Register();
        }

    }
}
