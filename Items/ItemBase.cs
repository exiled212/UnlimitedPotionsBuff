using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace UnlimitedPotisBuff.Items {
    public abstract class ItemBase : ModItem {

        protected abstract string GetName();
        protected abstract string GetDescription();
        protected abstract int GetItemId();
        protected abstract int GetBuffId();
        protected abstract int GetRarityId();
        protected abstract int GetTileId();

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(GetName());
            Tooltip.SetDefault(GetDescription());
        }

        public override void SetDefaults() {
            Item baseItem = GetBaseItem();
            item.width = baseItem.width;
            item.height = baseItem.height;
            item.value = Item.sellPrice(platinum: 1);
            item.rare = GetRarityId();
            item.maxStack = 1;
        }

        public override void AddRecipes() {
            Item baseItem = GetBaseItem();

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(GetItemId(), baseItem.maxStack);
            recipe.AddIngredient(ItemID.LargeAmber, 1);
            recipe.AddIngredient(ItemID.LargeAmethyst, 1);
            recipe.AddIngredient(ItemID.LargeDiamond, 1);
            recipe.AddIngredient(ItemID.LargeEmerald, 1);
            recipe.AddIngredient(ItemID.LargeRuby, 1);
            recipe.AddIngredient(ItemID.LargeSapphire, 1);
            recipe.AddIngredient(ItemID.LargeTopaz, 1);
            recipe.AddTile(GetTileId());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player) {
            player.AddBuff(GetBuffId(), 1, false);
        }

        private Item GetBaseItem() {
            Item baseItem = new Item();
            baseItem.SetDefaults(GetItemId());
            return baseItem;
        }

    }
}
