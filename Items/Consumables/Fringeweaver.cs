using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Consumables
{
    public class Fringeweaver : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fringe Weaver");
            Tooltip.SetDefault("It's like drinking ethylic alcohol with a spoonful of sugar.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.value = 3500;
            item.rare = 1;
			item.useStyle = 2;
			item.consumable = true;
			item.UseSound = SoundID.Item3;
			item.useAnimation = 17;
            item.useTime = 17;
            item.buffType = 25;
            item.buffTime = 72000;


            // Set other item.X values here
        }

        		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ale, 1);
			recipe.AddIngredient(ItemID.Gel, 6);
			recipe.AddTile(TileID.Kegs);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}