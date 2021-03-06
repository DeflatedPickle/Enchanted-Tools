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
			if (Main.rand.Next(5) != 0) return;
			var dustType = Main.rand.Next(3);

			switch (dustType) {
				case 0:
					dustType = 15;
					break;
						
				case 1:
					dustType = 57;
					break;
						
				default:
					dustType = 58;
					break;
			}
				
			var dust = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, dustType, player.direction * 2, 0f, 150, default(Color), 1.3f);
			dust.velocity *= 0.2f;
		}
	}
}
