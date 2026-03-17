using System.Collections.Generic;
using Ben10ExampleAddon.Content.Buffs;
using Ben10Mod;
using Ben10Mod.Content.Items.Accessories;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ben10ExampleAddon.Content.Transformation;

public class ExampleTransformation : Ben10Mod.Content.Transformations.Transformation {
    public override string FullID => "Ben10ExampleAddon:ExampleTransformation";
    public override string TransformationName => "Example Transformation";
    public override string IconPath => "Ben10Mod/Content/Interface/EmptyAlien";
    public override int TransformationBuffId => ModContent.BuffType<ExampleTransformationBuff>();

    public override IReadOnlyList<Ben10Mod.Content.Transformations.Transformation> ChildTransformations =>
        new List<Ben10Mod.Content.Transformations.Transformation>() {
            ModContent.GetInstance<ExampleUltimateTransformation>(),
            ModContent.GetInstance<ExampleCombinationTransformation>()
        };

    protected override bool CanUseChildTransformation(Player player, OmnitrixPlayer omp, Omnitrix omnitrix, Ben10Mod.Content.Transformations.Transformation childTransformation,
        string selectedTransformationId) {
        if (childTransformation == ModContent.GetInstance<ExampleUltimateTransformation>())
            return selectedTransformationId == FullID &&
                   omnitrix.CanUseEvolutionFeature(player, omp, this);

        if (childTransformation == ModContent.GetInstance<ExampleCombinationTransformation>())
            return selectedTransformationId == "Ben10Mod:HeatBlast" &&
                   omnitrix.CanUseEvolutionFeature(player, omp, this);

        return false;
    }

    public override int PrimaryAttack => ProjectileID.WoodenArrowFriendly;
    public override int PrimaryShootSpeed => 15;
    public override int PrimaryAttackSpeed => 20;

    public override void FrameEffects(Player player, OmnitrixPlayer omp) {
        player.head = ArmorIDs.Head.CopperHelmet;
        player.body = ArmorIDs.Body.CopperChainmail;
        player.legs = ArmorIDs.Legs.CopperGreaves;
    }
}
