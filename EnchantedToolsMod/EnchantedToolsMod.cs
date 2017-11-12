using System;
using Terraria.ModLoader;

namespace EnchantedToolsMod {
	class EnchantedToolsMod : Mod {
		public static EnchantedToolsMod instance;
		
		public EnchantedToolsMod() {
			Properties = new ModProperties() {
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void Load() {
			instance = this;
		}
	}
}
