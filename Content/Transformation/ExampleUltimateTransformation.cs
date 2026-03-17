using Ben10ExampleAddon.Content.Buffs;
using Ben10Mod;
using Ben10Mod.Content.Interface;
using Terraria;
using Terraria.ID;
using Ben10Mod.Content.Transformations;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Ben10ExampleAddon.Content.Transformation;

public class ExampleUltimateTransformation : Ben10Mod.Content.Transformations.Transformation {
    public override string FullID => "Ben10ExampleAddon:ExampleUltimateTransformation";
    public override string TransformationName => "Example Ultimate Transformation";
    public override int TransformationBuffId => ModContent.BuffType<ExampleUltimateTransformationBuff>();
    public override int PrimaryAttack => ProjectileID.Bullet;
    public override int PrimaryShootSpeed => 25;
    public override int PrimaryAttackSpeed => 15;

    public override Ben10Mod.Content.Transformations.Transformation ParentTransformation =>
        ModContent.GetInstance<ExampleTransformation>();

    public override void UpdateEffects(Player player, OmnitrixPlayer omp) {
        // Allows you to add an accessory, modded or vanilla, to your transformation. This slot is hidden.
        ModContent.GetInstance<AbilitySlot>().FunctionalItem = new Item(ItemID.CloudinaBottle);
    }

    public override void FrameEffects(Player player, OmnitrixPlayer omp) {
        player.head = ArmorIDs.Head.PlatinumHelmet;
        player.body = ArmorIDs.Body.PlatinumChainmail;
        player.legs = ArmorIDs.Legs.PlatinumGreaves;
    }
}