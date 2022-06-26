using Terraria.ID;
using Terraria;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace UnlimitedPotionsBuffs.Custom.LifeCrystal {
    class LifeCrystal : CustomItemBase {
        protected static int ItemId => ItemID.HeartLantern;

        protected override List<int> GetBuffIdList() {
            return new List<int>{ BuffID.HeartLamp };
        }

        protected override string GetName() {
            return "Reliquia de luz cristalizada";
        }

        protected override string GetDescription() {
            return "Esta piedra emite una luz que purifica el cuerpo y espiritu.\n\tMarque el objeto como favorito para activar su efecto.\n\tTe proporciona el buff de las linternas de corazón.";
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.TinkerersWorkbench;
        }

        protected override void ConfigItem() {
            Item baseItem = new();
            baseItem.SetDefaults(ItemId);
            Item.width = baseItem.width;
            Item.height = baseItem.height;
            Item.value = Item.sellPrice(platinum: 1);
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
