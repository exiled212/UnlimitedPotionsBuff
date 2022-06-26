using UnlimitedPotionsBuffs.Items;
using Terraria.ModLoader;
using Terraria;
using System.Collections.Generic;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class CustomItemBase : ItemBase {

        protected abstract string GetName();
        protected abstract string GetDescription();

        protected abstract List<int> GetBuffIdList();

        protected abstract void ConfigItem();

        public override void SetStaticDefaults() {
            Tooltip.SetDefault(GetDescription());
        }

        public override void SetDefaults() {
            Item.SetNameOverride(GetName());
            Item.rare = GetRarityId();
            Item.width = 14;
            Item.height = 24;
            Item.accessory = true;
            Item.consumable = false;
            Item.maxStack = 1;
            ConfigItem();
        }

        public override void UpdateInventory(Player player) {
            if (Item.favorited) {
                foreach (int buffId in GetBuffIdList()) {
                    player.AddBuff(buffId, 1, false);
                }
            }
        }
    }
}
