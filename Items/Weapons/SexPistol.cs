using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Weapons
{
    public class SexPistol : ModItem
    {
        public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Otherwise known as the Six Bullets.");
            DisplayName.SetDefault("Sex Pistol");
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
			item.UseSound = SoundID.Item41;
			item.autoReuse = false;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}   

	public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
					{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				type = mod.ProjectileType("SexPistolBullet"); // or ProjectileID.FireArrow;
			}		 // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
			return true;
		   	
	}
  }
}