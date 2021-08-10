using UnlimitedPotionsBuffs.Items;
using Terraria.ModLoader;
using Terraria;
using System.Collections.Generic;

namespace UnlimitedPotionsBuffs.AbstractItems {
    public abstract class CustomItemBase : ItemBase {

        protected Mod CalamityMod = ModLoader.GetMod("CalamityMod");

        protected abstract string GetName();
        protected abstract string GetDescription();

        protected abstract List<int> GetBuffIdList();

        protected abstract void ConfigItem();

        public override void SetStaticDefaults() {
            Tooltip.SetDefault(GetDescription());
        }

        public override void SetDefaults() {
            item.SetNameOverride(GetName());
            item.rare = GetRarityId();
            item.width = 14;
            item.height = 24;
            item.accessory = true;
            item.consumable = false;
            item.maxStack = 1;
            ConfigItem();
        }

        public override void UpdateInventory(Player player) {
            foreach(int buffId in GetBuffIdList()) {
                player.AddBuff(buffId, 1, false);
            }
        }
    }
}
