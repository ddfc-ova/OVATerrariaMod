using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace OVATerrariaMod.Items.Weapons
{
	public class WallBreaker : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This hammer can break every wall you place, even the nonexistent 4th.");
			DisplayName.SetDefault("4th Wall Breaking Hammer");
		}

		public override void SetDefaults() {
			item.damage = 35;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;        
			item.hammer = 100;      //How much hammer power the weapon has
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
			recipe.AddIngredient(ItemID.SunplateBlock, 10);
			recipe.AddIngredient(ItemID.DiscWall, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
