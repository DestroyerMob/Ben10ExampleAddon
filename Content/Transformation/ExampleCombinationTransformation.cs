using Ben10ExampleAddon.Content.Buffs;
using Ben10Mod;
using Ben10Mod.Content.Interface;
using Terraria;
using Terraria.ID;
using Ben10Mod.Content.Transformations;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Ben10ExampleAddon.Content.Transformation;

public class ExampleCombinationTransformation : Ben10Mod.Content.Transformations.Transformation {
    public override string FullID => "Ben10ExampleAddon:ExampleCombinationTransformation";
    public override string TransformationName => "Example Combination Transformation";
    public override int TransformationBuffId => ModContent.BuffType<ExampleCombinationTransformationBuff>();
    public override int PrimaryAttack => ProjectileID.RocketIII;
    public override int PrimaryShootSpeed => 25;
    public override int PrimaryAttackSpeed => 15;

    public override Ben10Mod.Content.Transformations.Transformation ParentTransformation =>
        ModContent.GetInstance<ExampleTransformation>();

    public override void OnHitNPC(Player player, OmnitrixPlayer omp, NPC target, NPC.HitInfo hit, int damageDone) {
        target.AddBuff(BuffID.OnFire3, 300);
    }

    public override void UpdateEffects(Player player, OmnitrixPlayer omp) {
        // Allows you to add an accessory, modded or vanilla, to your transformation. This slot is hidden.
        ModContent.GetInstance<AbilitySlot>().FunctionalItem = new Item(ItemID.CreativeWings);
    }

    public override void FrameEffects(Player player, OmnitrixPlayer omp) {
        player.head = ArmorIDs.Head.MoltenHelmet;
        player.body = ArmorIDs.Body.MoltenBreastplate;
        player.legs = ArmorIDs.Legs.MoltenGreaves;
    }
}