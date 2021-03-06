using Terraria.ModLoader;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotisBuff.Items {
    public abstract class ItemBase : ModItem {

        protected abstract string GetName();
        protected abstract string GetDescription();
        protected abstract int GetItemId();
        protected abstract int GetBuffId();
        protected abstract int GetRarityId();
        protected abstract int GetTileId();
        protected virtual int GetItemCount() { 
            return 30; 
        }

        public int BuffId() {
            return GetBuffId();
        }

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
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(GetItemId(), GetItemCount());
            recipe.AddIngredient(ItemType<GemsLock.GemsLock>(), 1);
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
