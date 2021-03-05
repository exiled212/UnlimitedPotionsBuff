﻿using Terraria.ID;

namespace UnlimitedPotisBuff.Items.NightOwlPotion {
    class NightOwlPotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de noctámbulo";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.NightOwlPotion;
        }

        protected override int GetBuffId() {
            return BuffID.NightOwl;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}