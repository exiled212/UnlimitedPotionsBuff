using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotisBuff.Vanilla;
using static Terraria.ModLoader.ModContent;

namespace UnlimitedPotisBuff.Custom.HeartOfGod {
    class HeartOfGod : CustomItemBase {

        protected override string GetName() {
            return "Corazón de los dioses";
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
            baseItem.SetDefaults(ItemID.LifeCrystal);
            item.width = baseItem.width;
            item.height = baseItem.height;
            item.value = Item.sellPrice(platinum: 1);
        }

        protected override ModRecipe ConfigureRecipe() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<FireHeartCrystal.FireHeartCrystal>(), 1);
            recipe.AddIngredient(ItemType<LifeCrystal.LifeCrystal>(), 1);
            recipe.AddIngredient(ItemType<HoneyHeartCrystal.HoneyHeartCrystal>(), 1);
            recipe.AddIngredient(ItemType<RegenerationPotion>(), 1);
            return recipe;
        }

        protected override void SetBuffs(Player player) {
            player.AddBuff(BuffID.HeartLamp, 1, false);
            player.AddBuff(BuffID.Honey, 1, false);
            player.AddBuff(BuffID.Campfire, 1, false);
            player.AddBuff(BuffID.DryadsWard, 1, false);
            player.AddBuff(BuffID.Regeneration, 1, false);
        }
    }
}
