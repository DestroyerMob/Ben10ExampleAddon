using Ben10ExampleAddon.Content.Buffs;
using Ben10Mod;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Ben10ExampleAddon.Content.Transformation;

public class ExampleTransformation : Ben10Mod.Content.Transformations.Transformation {
    public override string FullID => "Ben10ExampleAddon:ExampleTransformation";
    public override string TransformationName => "Example Transformation";
    public override string IconPath => "Ben10Mod/Content/Interface/EmptyAlien";
    public override int TransformationBuffId => ModContent.BuffType<ExampleTransformationBuff>();

    public override int PrimaryAttack => ProjectileID.WoodenArrowFriendly;
    public override int PrimaryShootSpeed => 15;
    public override int PrimaryAttackSpeed => 20;

    public override void FrameEffects(Player player, OmnitrixPlayer omp) {
        player.head = ArmorIDs.Head.CopperHelmet;
        player.body = ArmorIDs.Body.CopperChainmail;
        player.legs = ArmorIDs.Legs.CopperGreaves;
    }
}