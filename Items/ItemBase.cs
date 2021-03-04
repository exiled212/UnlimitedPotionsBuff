using Terraria.ModLoader;
using Terraria;

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
            Item refItem = new Item();
            refItem.SetDefaults(GetItemId());
            item.width = refItem.width;
            item.height = refItem.height;
            item.value = Item.sellPrice(platinum: 1);
            item.rare = GetRarityId();
            item.maxStack = 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(GetItemId(), 100);
            recipe.AddTile(GetTileId());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player) {
            player.AddBuff(GetBuffId(), 1, false);
        }

    }
}
