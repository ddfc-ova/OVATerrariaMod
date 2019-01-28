using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using OVATerrariaMod.Items;

namespace OVATerrariaMod
{
    public class OVATerrariaMod : Mod
    {
        public OVATerrariaMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}

