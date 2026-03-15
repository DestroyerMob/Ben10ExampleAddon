using Ben10Mod;
using Ben10Mod.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ben10ExampleAddon.Content.Items;

public class ExampleTransformationItem : ModItem {
    public override void SetDefaults() {
        Item.width = 40;
        Item.height = 40;
        Item.consumable = true;
        Item.useTime = Item.useAnimation = 20;
        Item.useStyle = ItemUseStyleID.HoldUp;
    }

    public override bool CanUseItem(Player player) {
        return !TransformationHandler.HasTransformation(player, "Ben10ExampleAddon:ExampleTransformation");
    }

    public override bool? UseItem(Player player) {
        TransformationHandler.AddTransformation(player, "Ben10ExampleAddon:ExampleTransformation");
        return base.UseItem(player);
    }
}