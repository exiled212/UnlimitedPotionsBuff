using UnlimitedPotionsBuffs.Items;
using static Terraria.ModLoader.ModContent;
using UnlimitedPotionsBuffs.Ingredients.GemsLock;
using Terraria;
using System.Collections.Generic;
using Terraria.UI;
using Terraria.ID;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class VanillaItemBase : ItemBase {
        protected abstract int GetItemId();
        protected abstract int GetBuffId();

        public override string Texture => "Terraria/Item_" + GetItemId();

        public override void SetStaticDefaults() {
            Item baseItem = new Item();
            baseItem.SetDefaults(GetItemId());
            ItemTooltip itemToolTip = baseItem.ToolTip;
            for (int i = 0; itemToolTip.Lines > i; i++) {
                description += "\n\t"+ itemToolTip.GetLine(i);
            }
            Tooltip.SetDefault(description);
        }

        public override void SetDefaults() {
            Item baseItem = new Item();
            baseItem.SetDefaults(GetItemId());
            item.SetNameOverride(baseItem.Name + nameBase);
            item.width = baseItem.width;
            item.height = baseItem.height;
            item.accessory = true;
            item.consumable = false;
            item.value = Item.sellPrice(platinum: 1);
            item.rare = GetRarityId();
            item.maxStack = 1;
        }

        protected override List<RecipeData> RecipesData(){
            Item baseItem = new Item();
            baseItem.SetDefaults(GetItemId());
            return new List<RecipeData> { 
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{ 
                    new RecipeData.ItemData(GetItemId(), 1),
                    new RecipeData.ItemData(ItemType<GemsLock>(), 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), baseItem.maxStack),
                    new RecipeData.ItemData(ItemID.LargeAmber, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), baseItem.maxStack),
                    new RecipeData.ItemData(ItemID.LargeAmethyst, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), baseItem.maxStack),
                    new RecipeData.ItemData(ItemID.LargeDiamond, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), baseItem.maxStack),
                    new RecipeData.ItemData(ItemID.LargeEmerald, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), baseItem.maxStack),
                    new RecipeData.ItemData(ItemID.LargeRuby, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), baseItem.maxStack),
                    new RecipeData.ItemData(ItemID.LargeSapphire, 1)
                }),
                new RecipeData(GetTileId(), new List<RecipeData.ItemData>{
                    new RecipeData.ItemData(GetItemId(), baseItem.maxStack),
                    new RecipeData.ItemData(ItemID.LargeTopaz, 1)
                })
            };
        }


        public override void UpdateInventory(Player player) {
            player.AddBuff(GetBuffId(), 1, false);
        }
    }
}
