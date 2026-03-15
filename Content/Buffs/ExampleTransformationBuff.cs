using Ben10Mod;
using Terraria;
using Terraria.ModLoader;

namespace Ben10ExampleAddon.Content.Buffs;

public class ExampleTransformationBuff : ModBuff {
    public override void Update(Player player, ref int buffIndex) {
        var omp = player.GetModPlayer<OmnitrixPlayer>();
        omp.currentTransformationId = "Ben10ExampleAddon:ExampleTransformation";
        omp.isTransformed = true;
    }
}