﻿using Terraria.ID;
using Terraria;
using UnlimitedPotionsBuffs.AbstractItems;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace UnlimitedPotionsBuffs.Custom.HoneyHeartCrystal {
    class HoneyHeartCrystal : CustomItemBase {

        protected int ItemId => ItemID.LifeCrystal;

        protected override List<int> GetBuffIdList() {
            return new List<int>{ BuffID.Honey };
        }

        protected override string GetName() {
            return "Reliquia de miel cristalizada";
        }

        protected override string GetDescription() {
            return "Un cristal que segrega miel con propiedades curativas.\n\tTe proporciona el buff de la miel.";
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

        protected override List<RecipeData> RecipesData() {
            return new List<RecipeData> {
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(ItemID.BottledHoney, 30),
                    new RecipeData.ItemData(ItemID.SuperHealingPotion, 30),
                    new RecipeData.ItemData(ItemType<GemsLock>(), 1)
                })
            };
        }
    }
}
