using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Placebles
{
    internal class AncientCroniumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Cronium Bar");
            Tooltip.SetDefault("It Seems Really Old.");
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

            Item.createTile = ModContent.TileType<Tiles.AncientCroniumBar>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<CroniumBar>(), 2)
                .AddTile(ModContent.TileType<Tiles.AncientForge>())
                .Register();

        }

    }
}
