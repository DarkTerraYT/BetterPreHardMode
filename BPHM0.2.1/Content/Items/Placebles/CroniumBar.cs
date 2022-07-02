using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace BetterPreHardMode.Content.Items.Placebles
{
    internal class CroniumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cronium Bar");
            Tooltip.SetDefault("#Metalic!");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
            ItemID.Sets.SortingPriorityMaterials[Type] = 51;

        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(silver: 2);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<Tiles.CroniumBar>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<CroniumOre>(), 4)
                .AddTile(TileID.Furnaces)
                .Register();

        }

    }
}
