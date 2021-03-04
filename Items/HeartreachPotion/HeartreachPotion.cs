using Terraria.ID;

namespace UnlimitedPotisBuff.Items.HeartreachPotion {
    public class HeartreachPotion : ItemBase {
        protected override string GetName() {
            return "Reliquia alcanzacorazón";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.HeartreachPotion; ;
        }

        protected override int GetBuffId() {
            return BuffID.Heartreach;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
