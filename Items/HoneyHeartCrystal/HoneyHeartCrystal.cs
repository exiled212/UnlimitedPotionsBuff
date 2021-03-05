using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotisBuff.Items.HoneyHeartCrystal {
    class HoneyHeartCrystal : ItemBase {

        protected override string GetName() {
            return "Reliquia de corazón de miel cristalizada";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return 0;
        }

        protected override int GetBuffId() {
            return BuffID.Honey;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledHoney, 30);
            recipe.AddIngredient(ItemID.HoneyCandelabra, 1);
            recipe.AddIngredient(ItemID.HoneyCandle, 1);
            recipe.AddIngredient(ItemID.HoneyLamp, 1);
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

    }
}
