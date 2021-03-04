﻿using Terraria.ID;

namespace UnlimitedPotisBuff.Items.WrathPotion {
    public class WrathPotion : ItemBase {

        protected override string getName() {
            return "Reliquia de ira";
        }

        protected override string getDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int getItemId() {
            return ItemID.WrathPotion; ;
        }

        protected override int getBuffId() {
            return BuffID.Wrath;
        }

        protected override int getRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int getTileId() {
            return TileID.AlchemyTable;
        }

    }
}
