using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Tiles;

namespace BetterPreHardMode.Content.Items.Placebles
{
    internal class CroniumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cronium Ore");
            Tooltip.SetDefault("I Will Exchange This For Something - Nobody Ever");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 50;
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(copper: 50);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 15;
            Item.useTurn = true;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<CroniumOres>();


        }
    }
}
