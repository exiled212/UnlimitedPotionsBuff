using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotisBuff.Ingredients.GemsLock;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotisBuff.Custom.HoneyHeartCrystal {
    class HoneyHeartCrystal : CustomItemBase {

        protected int ItemId => ItemID.LifeCrystal;
        protected int BuffId => BuffID.Honey;

        protected override string GetName() {
            return "Reliquia de corazón de miel cristalizada";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

        protected override void ConfigItem() {
            Item baseItem = new Item();
            baseItem.SetDefaults(ItemId);
            item.width = baseItem.width;
            item.height = baseItem.height;
            item.value = Item.sellPrice(platinum: 1);
        }

        protected override ModRecipe ConfigureRecipe() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledHoney, 30);
            recipe.AddIngredient(ItemID.HoneyCandelabra, 1);
            recipe.AddIngredient(ItemID.HoneyCandle, 1);
            recipe.AddIngredient(ItemID.HoneyLamp, 1);
            recipe.AddIngredient(ItemType<GemsLock>(), 1);
            return recipe;
        }

        protected override void SetBuffs(Player player) {
            player.AddBuff(BuffId, 1, false);
        }
    }
}
