using Terraria.ModLoader;

namespace EnchantedTools {
	class EnchantedTools : Mod {
		public static EnchantedTools instance;
		
		public EnchantedTools() {
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
