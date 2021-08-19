using Terraria.ID;
using Terraria;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace UnlimitedPotionsBuffs.Custom.FireHeartCrystal {
    class FireHeartCrystal : CustomItemBase {
        protected int ItemId => ItemID.LifeCrystal;
        protected override List<int> GetBuffIdList() {
            return new List<int>{ BuffID.Campfire };
        }

        protected override string GetName() {
            return "Reliquia de fuego cristalizada";
        }

        protected override string GetDescription() {
            return "Sientes que te abraza el calor de una fogata.\n\tMarque el objeto como favorito para activar su efecto.\n\tTe provee el buff de la fogata";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.Campfire;
        }

        protected override void ConfigItem() {
            Item baseItem = new Item();
            baseItem.SetDefaults(ItemId);
            item.width = baseItem.width;
            item.height = baseItem.height;
            item.value = Item.sellPrice(platinum: 1);
        }

        protected override List<RecipeData> RecipesData() {
            return new List<RecipeData> {
                new RecipeData(GetTileId(), new List<RecipeData.ItemData> {
                    new RecipeData.ItemData(ItemId, 20),
                    new RecipeData.ItemData(ItemType<GemsLock>(), 1)
                })
            };
        }

    }
}
