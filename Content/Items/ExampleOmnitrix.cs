using Ben10Mod;
using Ben10Mod.Content.Items.Accessories;
using log4net.Util;
using Terraria;
using Terraria.ID;

namespace Ben10ExampleAddon.Content.Items;

public class ExampleOmnitrix : Omnitrix {
    public override int MaxOmnitrixEnergy => 5000;
    public override int OmnitrixEnergyRegen => 300;
    public override int OmnitrixEnergyDrain => 1;
    public override bool UseEnergyForTransformation => true;
    public override int TranformationSwapCost => 0;
    public override int TimeoutDuration => 10;
    public override int TransformationDuration => 2;
    public override bool EvolutionFeature => true;
    public override int EvolutionCost => 5;
    public override string Texture => "Ben10ExampleAddon/Content/Items/ExampleOmnitrix";

    public override void AddRecipes() {
        CreateRecipe()
            .AddIngredient(ItemID.IronBar, 10)
            .Register();
        
        CreateRecipe()
            .AddIngredient(ItemID.LeadBar, 10)
            .Register();
    }
}