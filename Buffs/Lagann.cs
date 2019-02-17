using Terraria;
using Terraria.ModLoader;
using OVATerrariaMod.Mount;

namespace OVATerrariaMod.Buffs
{
	public class Lagann : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Lagann");
			Description.SetDefault("You can pierce the heavens with this thing!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(mod.MountType<Mount.Lagann>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
