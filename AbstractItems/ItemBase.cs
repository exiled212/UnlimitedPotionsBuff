using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace UnlimitedPotionsBuffs.Items {
    public abstract class ItemBase : ModItem {

        protected string description = "Parece que el contenido de la posión se cristalizo.\n\tMarque el objeto como favorito para activar su efecto.";

        protected string nameBase = " cristalizada";

        protected abstract int GetRarityId();
        protected abstract int GetTileId();

        protected abstract List<RecipeData> RecipesData();

        public override void AddRecipes() {
            foreach (RecipeData recipeData in RecipesData()) {
                if (recipeData.ItemsData.Count > 0) {
                    Recipe recipe = CreateRecipe();
                    recipe.AddTile(recipeData.TileId);
                    foreach (RecipeData.ItemData itemData in recipeData.ItemsData) {
                        recipe.AddIngredient(itemData.ItemId, itemData.Stack);
                    }
                    recipe.Register();
                }
            }
        }

        protected class RecipeData {

            public int TileId { get; }

            public List<ItemData> ItemsData { get; }
            public RecipeData(int tileId, List<ItemData> itemsData) {
                TileId = tileId;
                ItemsData = itemsData;
            }

            public class ItemData {
                public int ItemId { get; }
                public int Stack { get; }

                public ItemData(int itemId, int stack) {
                    ItemId = itemId;
                    Stack = stack;
                }

            }

        }

    }
}
