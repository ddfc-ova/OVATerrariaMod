using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OVATerrariaMod.Armor.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class KaminaShades : ModItem
	{
		        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kamina Shades");
            Tooltip.SetDefault("Believe in the me that believes in you.");}

				public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
drawHair = true;}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Lens, 2);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = 1;
			item.vanity = true;
		}
	}
}