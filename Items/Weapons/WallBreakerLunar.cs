using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Weapons
{
	public class WallBreakerLunar : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This hammer can break every wall you place, even the nonexistent 5th.");
			DisplayName.SetDefault("5th Wall Breaking Hammer");
		}

		public override void SetDefaults() {
			item.damage = 65;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;        
			item.hammer = 500;      //How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WallBreaker", 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
