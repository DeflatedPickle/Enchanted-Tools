using Terraria.ID;
using Terraria.ModLoader;

namespace EnchantedTools.Items {
	public class EnchantedAxe : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Enchanted Axe");
			// Tooltip.SetDefault("Shoots an enchanted beam");
		}
		
		public override void SetDefaults() {
			item.damage = 15;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.scale = 1.15f;
			item.useTime = 18;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4.5f;
			item.value = 50000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.axe = 14;
		}
	}
}
