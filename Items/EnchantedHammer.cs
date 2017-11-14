using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnchantedTools.Items {
	public class EnchantedHammer : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Enchanted Hammer");
			// Tooltip.SetDefault("Shoots an enchanted beam");
		}
		
		public override void SetDefaults() {
			item.damage = 19;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.scale = 1.25f;
			item.useTime = 20;
			item.useAnimation = 23;
			item.useStyle = 1;
			item.knockBack = 5f;
			item.value = 50000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.hammer = 53;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.Next(1) == 0) {
				Lighting.AddLight(player.Center, new Vector3(1f, 1f, 1f));
			}
		}
	}
}
