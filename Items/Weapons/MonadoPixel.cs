/* using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Weapons
{
	public class MonadoPixel : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded sword.");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults() {
			item.damage = 17;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 35;            //Weapon's texture's width
			item.height = 35;           //Weapon's texture's height
			item.useTime = 30;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 30;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 10;         //The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(gold: 1);           //The value of the weapon
			item.rare = 2;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
			item.useTurn = true;
		}


		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2, 0);
		}
			}
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 9);			
			recipe.AddTile(TileID.LunarCraftingStation);	
			recipe.SetResult(this);
			recipe.AddRecipe();
		} 

		// Star Wrath/Starfury style weapon. Spawn projectiles from sky that aim towards mouse.
		// See Source code for Star Wrath projectile to see how it passes through tiles.
		/*	The following changes to SetDefaults 
		 	item.shoot = 503;
			item.shootSpeed = 8f;
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++)
			{
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
				position.Y -= (100 * i);
				Vector2 heading = target - position;
				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}
				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}
				heading.Normalize();
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
		}*/


