using Terraria.ID;
using Terraria.ModLoader;
using OVATerrariaMod.Mount;

namespace OVATerrariaMod.Items
{
	public class Lagann : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("You feel a strange glow coming from this item.");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = mod.MountType("Lagann");
		}
		}
	
}