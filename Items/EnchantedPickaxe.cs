using Terraria.ID;
using Terraria.ModLoader;

namespace EnchantedToolsMod.Items {
	public class EnchantedPickaxe : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Enchanted Pickaxe");
			Tooltip.SetDefault("Shoots an enchanted beam");
		}
		public override void SetDefaults() {
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
