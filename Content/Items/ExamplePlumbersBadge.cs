using Ben10Mod.Content.Items.Weapons;
using Terraria;
using Terraria.ID;

namespace Ben10ExampleAddon.Content.Items;

public class ExamplePlumbersBadge : PlumbersBadge {
    public override int BaseDamage => 250;
    public override float AdditionalProjectileChance => 1.5f;
    
    public override void AddRecipes() {
        CreateRecipe()
            .AddIngredient(ItemID.DirtBlock, 10)
            .Register();
    }
}