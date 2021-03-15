using Terraria.ModLoader;


namespace UnlimitedPotisBuff.Items {
    public abstract class ItemBase : ModItem {
        protected abstract int GetRarityId();
        protected abstract int GetTileId();

    }
}
