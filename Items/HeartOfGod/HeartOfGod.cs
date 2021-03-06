using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotisBuff.Items.HeartOfGod {
    class HeartOfGod : ItemBase {

        protected override string GetName() {
            return "Corazón de los dioses";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return 0;
        }

        protected override int GetBuffId() {
            return 0;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        public override void UpdateInventory(Player player) {
            player.AddBuff(BuffID.HeartLamp, 1, false);
            player.AddBuff(BuffID.Honey, 1, false);
            player.AddBuff(BuffID.Campfire, 1, false);
            player.AddBuff(BuffID.DryadsWard, 1, false);
            player.AddBuff(BuffID.Regeneration, 1, false);
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<FireHeartCrystal.FireHeartCrystal>(), 1);
            recipe.AddIngredient(ItemType<LifeCrystal.LifeCrystal>(), 1);
            recipe.AddIngredient(ItemType<HoneyHeartCrystal.HoneyHeartCrystal>(), 1);
            recipe.AddIngredient(ItemType<RegenerationPotion.RegenerationPotion>(), 1);
            recipe.AddTile(GetTileId());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
