﻿using Terraria.ID;

namespace UnlimitedPotisBuff.Items.ObsidianSkinPotion {
    class ObsidianSkinPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de piel de obsidiana";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.ObsidianSkinPotion;
        }

        protected override int GetBuffId() {
            return BuffID.ObsidianSkin;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
