using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Weapons
{
    public class sawedoffshotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sawed-Off Shotgun");
        }

 		public override void SetDefaults()
		{
			item.damage = 7;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 50000;
			item.rare = 2;
			item.UseSound = SoundID.Item38;
			item.autoReuse = false;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(40)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}        	
	}
}