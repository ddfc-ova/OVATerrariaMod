using Terraria; 
using Terraria.ID; 
using Terraria.ModLoader;

namespace OVATerrariaMod.Projectiles
{
    public class ThePoleProjectile : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("The Pole");
	}

        public override void SetDefaults()
        {
		projectile.arrow = true;
		projectile.width = 30;
		projectile.height = 30;
		projectile.aiStyle = 1;
		projectile.friendly = true;
		projectile.ranged = true;
        aiType = ProjectileID.JavelinFriendly;
        projectile.rotation = projectile.spriteDirection = projectile.direction;
        }

	// Additional hooks/methods here.
    }
}