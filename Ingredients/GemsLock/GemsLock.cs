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
            CreateRecipe()
                .AddIngredient( ItemID.LargeAmber, 1 )
                .AddIngredient( ItemID.LargeAmethyst, 1 )
                .AddIngredient( ItemID.LargeDiamond, 1 )
                .AddIngredient( ItemID.LargeEmerald, 1 )
                .AddIngredient( ItemID.LargeRuby, 1 )
                .AddIngredient( ItemID.LargeSapphire, 1 )
                .AddIngredient( ItemID.LargeTopaz, 1 )
                .Register();
        }

    }
}
