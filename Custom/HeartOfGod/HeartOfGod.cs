using Terraria.ID;
using Terraria;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Vanilla;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace UnlimitedPotionsBuffs.Custom.HeartOfGod {
    class HeartOfGod : CustomItemBase {

        protected override string GetName() {
            return "Reliquia de tiempo cristalizada";
        }

        protected override List<int> GetBuffIdList() {
            return new List<int> {
                BuffID.HeartLamp,
                BuffID.Honey,
                BuffID.Campfire,
                BuffID.DryadsWard,
                BuffID.Regeneration
            };
        }

        protected override string GetDescription() {
            return "Este objeto te permitira disfrutar de la vida eterna.\n\tTe otorga todos los buffs de regeneración de vida.";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.LunarCraftingStation;
        }

        protected override void ConfigItem() {
            Item baseItem = new Item();
            baseItem.SetDefaults(ItemID.LifeCrystal);
            item.width = baseItem.width;
            item.height = baseItem.height;
            item.value = Item.sellPrice(platinum: 1);
        }

        protected override List<RecipeData> RecipesData() {
            return new List<RecipeData> {
                new RecipeData(GetTileId(), new List<RecipeData.ItemData> {
                    new RecipeData.ItemData(ItemType<FireHeartCrystal.FireHeartCrystal>(), 1),
                    new RecipeData.ItemData(ItemType<LifeCrystal.LifeCrystal>(), 1),
                    new RecipeData.ItemData(ItemType<HoneyHeartCrystal.HoneyHeartCrystal>(), 1),
                    new RecipeData.ItemData(ItemType<RegenerationPotion>(), 1)
                })
            };
        }

    }
}
