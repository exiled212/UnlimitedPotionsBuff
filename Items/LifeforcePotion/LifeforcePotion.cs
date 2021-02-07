

using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace UnlimitedPotisBuff.Items.LifeforcePotion {
    public class LifeforcePotion : ModItem {

        public static string NAME = "Reliquia de fuerza vital";
        public static string DESCRIPTION = "Esta reliquia te provee de su poder con solo tenerla";
        public static int ITEM_ID = ItemID.LifeforcePotion;
        public static int BUFF_ID = BuffID.Lifeforce;

        public static int RARITY_ID = ItemRarityID.Orange;
        public static int TILE_ID = TileID.AlchemyTable;

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(NAME);
            Tooltip.SetDefault(DESCRIPTION);
        }

        public override void SetDefaults() {
            Item refItem = new Item();
            refItem.SetDefaults(ITEM_ID);
            item.width = refItem.width;
            item.height = refItem.height;
            item.value = Item.sellPrice(platinum: 1);
            item.rare = RARITY_ID;
            item.maxStack = 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ITEM_ID, 100);
            recipe.AddTile(TILE_ID);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player) {
            player.AddBuff(BUFF_ID, 1, false);
        }

    }
}
