using Terraria; 
using Terraria.ID; 
using Terraria.ModLoader;

namespace OVATerrariaMod.Projectiles
{
    public class D20Projectile : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("D20");
	}

        public override void SetDefaults()
        {
		projectile.arrow = true;
		projectile.width = 17;
		projectile.height = 17;
		projectile.aiStyle = 14;
		projectile.friendly = true;
		projectile.ranged = true;
        aiType = ProjectileID.SpikyBall;
        projectile.rotation = projectile.spriteDirection = projectile.direction;
        }

	// Additional hooks/methods here.
    }
}