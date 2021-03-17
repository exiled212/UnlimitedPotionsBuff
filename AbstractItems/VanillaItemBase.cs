using UnlimitedPotionsBuffs.Items;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using Terraria;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class VanillaItemBase : ItemBase {
        protected abstract int GetItemId();
        protected abstract int GetBuffId();

        public override string Texture => "Terraria/Item_" + GetItemId();

        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Esta reliquia te provee de su poder con solo tenerla");
        }

        public override void SetDefaults() {
            Item baseItem = new Item();
            baseItem.SetDefaults(GetItemId());
            item.SetNameOverride("Concentrado de " + baseItem.Name);
            item.width = baseItem.width;
            item.height = baseItem.height;
            item.value = Item.sellPrice(platinum: 1);
            item.rare = GetRarityId();
            item.maxStack = 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(GetItemId(), 30);
            recipe.AddIngredient(ItemType<GemsLock>(), 1);
            recipe.AddTile(GetTileId());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player) {
            player.AddBuff(GetBuffId(), 1, false);
        }
    }
}
