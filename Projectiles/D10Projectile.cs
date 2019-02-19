using Terraria; 
using Terraria.ID; 
using Terraria.ModLoader;

namespace OVATerrariaMod.Projectiles
{
    public class D10Projectile : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("D10");
	}

        public override void SetDefaults()
        {
		projectile.arrow = true;
		projectile.width = 15;
		projectile.height = 15;
		projectile.aiStyle = 14;
		projectile.friendly = true;
		projectile.ranged = true;
        aiType = ProjectileID.SpikyBall;
        projectile.rotation = projectile.spriteDirection = projectile.direction;
        }

	// Additional hooks/methods here.
    }
}