using Microsoft.Xna.Framework;
using Terraria;
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

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.Next(5) == 0) {
				int dustType = Main.rand.Next(3);
				
				if (dustType == 0) {
					dustType = 15;
				} else if (dustType == 1) {
					dustType = 57;
				} else {
					dustType = 58;
				}
				
				Dust dust = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, dustType, player.direction * 2, 0f, 150, default(Color), 1.3f);
				dust.velocity *= 0.2f;
			}
		}
	}
}
