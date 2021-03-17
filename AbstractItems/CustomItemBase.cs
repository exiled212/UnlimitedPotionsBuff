using UnlimitedPotionsBuffs.Items;
using Terraria.ModLoader;
using Terraria;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class CustomItemBase : ItemBase {
        protected abstract string GetName();
        protected abstract string GetDescription();
        protected abstract void SetBuffs(Player player);

        protected abstract ModRecipe ConfigureRecipe();

        protected abstract void ConfigItem();

        public override void SetStaticDefaults() {
            Tooltip.SetDefault(GetDescription());
        }

        public override void SetDefaults() {
            item.SetNameOverride(GetName());
            item.rare = GetRarityId();
            item.maxStack = 1;
            ConfigItem();
        }

        public override void UpdateInventory(Player player) {
            SetBuffs(player);
        }

        public override void AddRecipes() {
            ModRecipe recipe = ConfigureRecipe();
            recipe.AddTile(GetTileId());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
