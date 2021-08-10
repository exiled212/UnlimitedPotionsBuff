using UnlimitedPotionsBuffs.Items;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using Terraria;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.ID;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class CalamityItemBase : ItemBase {

        protected Mod CalamityMod = ModLoader.GetMod("CalamityMod");

        protected abstract string GetItemName();
        protected abstract string GetBuffName();

        public override string Texture => (CalamityMod != null)?"CalamityMod/Items/Potions/" + GetItemName(): "UnlimitedPotionsBuffs/Textures/Default";

        public override void SetStaticDefaults() {
            if (CalamityMod != null) {
                ModBuff currentBuff = CalamityMod.GetBuff(GetBuffName());
                string descriptionBuff = currentBuff.Description.GetTranslation(GameCulture.Spanish);
                description += "\n\t" + descriptionBuff;
                Tooltip.SetDefault(description);
            }
        }

        public override void SetDefaults() {
            if (CalamityMod != null) {
                int itemId = CalamityMod.ItemType(GetItemName());
                Item baseItem = new Item();
                baseItem.SetDefaults(itemId);
                item.SetNameOverride(baseItem.Name + nameBase);
                item.width = baseItem.width;
                item.height = baseItem.height;
                item.accessory = true;
                item.consumable = false;
                item.value = Item.sellPrice(platinum: 1);
                item.rare = GetRarityId();
                item.maxStack = 1;
            }
        }

        protected override List<RecipeData> RecipesData() {
            int itemId = CalamityMod.ItemType(GetItemName());
            int maxStacks = 30; //I not use maxStak from itemId because is 999 stacks.
            return new List<RecipeData> {
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, 1),
                    new RecipeData.ItemData(ItemType<GemsLock>(), 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, maxStacks),
                    new RecipeData.ItemData(ItemID.LargeAmber, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, maxStacks),
                    new RecipeData.ItemData(ItemID.LargeAmethyst, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, maxStacks),
                    new RecipeData.ItemData(ItemID.LargeDiamond, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, maxStacks),
                    new RecipeData.ItemData(ItemID.LargeEmerald, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, maxStacks),
                    new RecipeData.ItemData(ItemID.LargeRuby, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, maxStacks),
                    new RecipeData.ItemData(ItemID.LargeSapphire, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(itemId, maxStacks),
                    new RecipeData.ItemData(ItemID.LargeTopaz, 1)
                })
            };
        }

        public override void AddRecipes() {
            foreach (RecipeData recipeData in RecipesData()) {
                if (recipeData.ItemsData.Count > 0) {
                    ModRecipe recipe = new ModRecipe(mod);
                    recipe.AddTile(recipeData.TileId);
                    recipe.SetResult(this);
                    foreach (RecipeData.ItemData itemData in recipeData.ItemsData) {
                        recipe.AddIngredient(itemData.ItemId, itemData.Stack);
                    }
                    AddIngredients(recipe);
                    recipe.AddRecipe();
                }
            }
        }

        protected abstract void AddIngredients(ModRecipe recipe);

        public override void UpdateInventory(Player player) {
            if (CalamityMod != null) {
                int buffId = CalamityMod.BuffType(GetBuffName());
                player.AddBuff(buffId, 1, false);
            }
        }

    }
}
