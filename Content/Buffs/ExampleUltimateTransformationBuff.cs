using Ben10Mod;
using Terraria;
using Terraria.ModLoader;

namespace Ben10ExampleAddon.Content.Buffs;

public class ExampleUltimateTransformationBuff : ModBuff {
    public override void Update(Player player, ref int buffIndex) {
        var omp = player.GetModPlayer<OmnitrixPlayer>();
        omp.currentTransformationId = "Ben10ExampleAddon:ExampleUltimateTransformation";
        omp.isTransformed = true;
    }
}