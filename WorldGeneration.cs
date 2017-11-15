﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnchantedTools {
    public class WorldGeneration : ModWorld {
        public override void PostWorldGen() {
            var items = new int[] {
                mod.ItemType("EnchantedPickaxe"),
                mod.ItemType("EnchantedAxe"),
                mod.ItemType("EnchantedHammer")
            };

            var itemChoice = 0;

            for (int chestIndex = 0; chestIndex < 1000; chestIndex++) {
                Chest chest = Main.chest[chestIndex];

                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 1 * 36) {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++) {
                        if (chest.item[inventoryIndex].type == 0) {
                            chest.item[inventoryIndex].SetDefaults(items[itemChoice]);
                            itemChoice = (itemChoice + 1) % items.Length;
                            break;
                        }
                    }
                }
            }
        }
    }
}