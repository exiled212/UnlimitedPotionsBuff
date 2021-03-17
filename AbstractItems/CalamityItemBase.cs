using UnlimitedPotionsBuffs.Items;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using Terraria;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class CalamityItemBase : ItemBase {

        protected Mod CalamityMod = ModLoader.GetMod("CalamityMod");

        protected abstract string GetItemName();
        protected abstract string GetBuffName();

        public override string Texture => (CalamityMod != null)?"CalamityMod/Items/Potions/" + GetItemName(): "UnlimitedPotionsBuffs/Textures/Default";

        public override void SetStaticDefaults() {
            if (CalamityMod != null) {
                Tooltip.SetDefault("Esta reliquia te provee de su poder con solo tenerla");
            }
        }

        public override void SetDefaults() {
            if (CalamityMod != null) {
                int itemId = CalamityMod.ItemType(GetItemName());
                Item baseItem = new Item();
                baseItem.SetDefaults(itemId);
                item.SetNameOverride("Concentrado de " + baseItem.Name);
                item.width = baseItem.width;
                item.height = baseItem.height;
                item.value = Item.sellPrice(platinum: 1);
                item.rare = GetRarityId();
                item.maxStack = 1;
            }
        }

        public override void AddRecipes() {
            if (CalamityMod != null) {
                int itemId = CalamityMod.ItemType(GetItemName());
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(itemId, 30);
                AddIngredients(recipe);
                recipe.AddIngredient(ItemType<GemsLock>(), 1);
                recipe.AddTile(GetTileId());
                recipe.SetResult(this);
                recipe.AddRecipe();
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
