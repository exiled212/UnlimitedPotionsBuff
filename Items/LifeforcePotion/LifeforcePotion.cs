using Terraria.ID;

namespace UnlimitedPotisBuff.Items.LifeforcePotion {
    public class LifeforcePotion : ItemBase {

        protected override string GetName() {
            return "Reliquia de fuerza vital";
        }

        protected override string GetDescription() {
            return "Esta reliquia te provee de su poder con solo tenerla";
        }

        protected override int GetItemId() {
            return ItemID.LifeforcePotion;
        }

        protected override int GetBuffId() {
            return BuffID.Lifeforce;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
