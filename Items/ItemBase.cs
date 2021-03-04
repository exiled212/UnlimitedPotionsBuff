using Terraria.ModLoader;
using Terraria;

namespace UnlimitedPotisBuff.Items {
    public abstract class ItemBase : ModItem {

        protected abstract string getName();
        protected abstract string getDescription();
        protected abstract int getItemId();
        protected abstract int getBuffId();
        protected abstract int getRarityId();
        protected abstract int getTileId();

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(getName());
            Tooltip.SetDefault(getDescription());
        }

        public override void SetDefaults() {
            Item refItem = new Item();
            refItem.SetDefaults(getItemId());
            item.width = refItem.width;
            item.height = refItem.height;
            item.value = Item.sellPrice(platinum: 1);
            item.rare = getRarityId();
            item.maxStack = 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(getItemId(), 100);
            recipe.AddTile(getTileId());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player) {
            player.AddBuff(getBuffId(), 1, false);
        }

    }
}
