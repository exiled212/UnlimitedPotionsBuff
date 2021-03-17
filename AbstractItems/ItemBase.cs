using Terraria.ModLoader;


namespace UnlimitedPotionsBuffs.Items {
    public abstract class ItemBase : ModItem {
        protected abstract int GetRarityId();
        protected abstract int GetTileId();

    }
}
