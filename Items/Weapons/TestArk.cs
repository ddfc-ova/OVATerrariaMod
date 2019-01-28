using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OVATerrariaMod.Items.Weapons
{
public class TestArk : ModItem
{
public override void SetStaticDefaults()
{
DisplayName.SetDefault("Test Ark");
Tooltip.SetDefault("The life force of the planet");
}

public override void SetDefaults()
{
item.damage = 600;
item.melee = true;
item.width = 66;
item.height = 70;
item.useTime = 7;
item.useAnimation = 25;
item.channel = true;
item.noUseGraphic = true;
item.noMelee = true;
item.useStyle = 5;
item.knockBack = 6;
item.value = Item.buyPrice(0, 22, 50, 0);
item.rare = 9;
item.UseSound = SoundID.Item1;
item.autoReuse = true;
item.shoot = mod.ProjectileType("Swingy");
item.shootSpeed = 40f;
}
}
}