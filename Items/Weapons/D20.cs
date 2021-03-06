﻿using OVATerrariaMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Weapons
{
	public class D20 : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("It's a D20.");
			DisplayName.SetDefault("D20");
		}

		public override void SetDefaults() {
			item.damage = 40;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 24;
			item.shootSpeed = 3.7f;
			item.knockBack = 6.5f;
			item.width = 17;
			item.height = 18;
			item.scale = 1f;
			item.rare = 5;
			item.value = Item.sellPrice(silver: 10);

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<D20Projectile>();
		}

		}
	}

