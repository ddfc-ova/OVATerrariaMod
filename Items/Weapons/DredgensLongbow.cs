using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Weapons
{
    public class DredgensLongbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dredgen's Longbow");
        }

        public override void SetDefaults()
        {
            item.damage = 32;
			item.ranged = true; // For Ranged Weapon
			item.width = 16;
            item.height = 24;
            item.useTime = 4;
			item.reuseDelay = 14;
            item.useAnimation = 12;
            item.useStyle = 5; // Bow Use Style
            item.noMelee = true; // Doesn't deal damage if an enemy touches at melee range.
            item.value = 10000; // Another way to handle value of item.
            item.rare = 2;
            item.UseSound = SoundID.Item5; // Sound for Bows
            item.useAmmo = AmmoID.Arrow; // The ammo used with this weapon
            item.shoot = 1;
            item.shootSpeed = 14f;
        }
    		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}
	}
}