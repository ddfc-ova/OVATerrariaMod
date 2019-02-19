using Terraria; 
using Terraria.ID; 
using Terraria.ModLoader;

namespace OVATerrariaMod.Projectiles
{
    public class D6Projectile : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("D6");
	}

        public override void SetDefaults()
        {
		projectile.arrow = true;
		projectile.width = 14;
		projectile.height = 14;
		projectile.aiStyle = 14;
		projectile.friendly = true;
		projectile.ranged = true;
        aiType = ProjectileID.SpikyBall;
        projectile.rotation = projectile.spriteDirection = projectile.direction;
        }

	// Additional hooks/methods here.
    }
}