using Terraria.ID;

namespace Ben10ExampleAddon.Content.Transformation;

public class ExampleUltimateTransformation : ExampleTransformation {
    public override int PrimaryAttack => ProjectileID.Bullet;
    public override int PrimaryAttackSpeed => 10;
    public override int PrimaryShootSpeed => 10;
    
    
}