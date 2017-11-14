using Terraria.ModLoader;

namespace EnchantedTools {
	class EnchantedTools : Mod {
		private static EnchantedTools _instance;
		
		public EnchantedTools() {
			Properties = new ModProperties() {
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void Load() {
			_instance = this;
		}
	}
}
