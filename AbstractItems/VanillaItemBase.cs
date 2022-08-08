using UnlimitedPotionsBuffs.Items;
using static Terraria.ModLoader.ModContent;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using Terraria;
using System.Collections.Generic;
using Terraria.UI;
using Terraria.ID;
using System;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class VanillaItemBase : ItemBase {
        protected abstract int GetItemId();
        protected abstract int GetBuffId();

        private readonly static int MAX_STACKS = 30;

        public override string Texture => "Terraria/Images/Item_" + GetItemId();

        public override void SetStaticDefaults() {
            Item baseItem = new();
            baseItem.SetDefaults(GetItemId());
            ItemTooltip itemToolTip = baseItem.ToolTip;
            for (int i = 0; itemToolTip.Lines > i; i++) {
                description += "\n\t"+ itemToolTip.GetLine(i);
            }
            Tooltip.SetDefault(description);
        }

        public override void SetDefaults() {
            Item baseItem = new();
            baseItem.SetDefaults(GetItemId());
            Item.SetNameOverride(baseItem.Name + nameBase);
            Item.width = baseItem.width;
            Item.height = baseItem.height;
            Item.accessory = true;
            Item.consumable = false;
            Item.value = Item.sellPrice(platinum: 1);
            Item.rare = GetRarityId();
            Item.maxStack = 1;
        }

        protected override List<RecipeData> RecipesData(){
            Item baseItem = new();
            baseItem.SetDefaults(GetItemId());
            int maxStacks = Math.Min( MAX_STACKS, baseItem.maxStack );
            return new List<RecipeData> { 
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{ 
                    new RecipeData.ItemData(GetItemId(), 1),
                    new RecipeData.ItemData(ItemType<GemsLock>(), 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), maxStacks),
                    new RecipeData.ItemData(ItemID.LargeAmber, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), maxStacks),
                    new RecipeData.ItemData(ItemID.LargeAmethyst, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), maxStacks),
                    new RecipeData.ItemData(ItemID.LargeDiamond, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), maxStacks),
                    new RecipeData.ItemData(ItemID.LargeEmerald, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), maxStacks),
                    new RecipeData.ItemData(ItemID.LargeRuby, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), maxStacks),
                    new RecipeData.ItemData(ItemID.LargeSapphire, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), maxStacks),
                    new RecipeData.ItemData(ItemID.LargeTopaz, 1)
                })
            };
        }


        public override void UpdateInventory(Player player) {
            if (Item.favorited) {
                player.AddBuff(GetBuffId(), 1, false);
            }
        }
    }
}
