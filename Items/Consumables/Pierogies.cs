using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Consumables
{
    public class Pierogies : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded item.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.value = 100;
            item.rare = 1;
			item.useStyle = 2;
			item.consumable = true;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 17;
            item.useTime = 17;
            item.buffType = 26;
            item.buffTime = 72000;


            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}