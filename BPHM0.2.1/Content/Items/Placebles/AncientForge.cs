using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Placebles
{
    internal class AncientForge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Forge");
            Tooltip.SetDefault("Used To Craft ancient Things.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            ItemID.Sets.SortingPriorityMaterials[Type] = 60;

        }

        public override void SetDefaults()
        {
            Item.width = 36;
            Item.height = 24;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(gold: 2);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<Tiles.AncientForge>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<CroniumBar>(), 5)
                .AddIngredient(ItemID.TissueSample, 3)
                .AddTile(TileID.DemonAltar)
                .Register();

            CreateRecipe()
               .AddIngredient(ModContent.ItemType<CroniumBar>(), 5)
               .AddIngredient(ItemID.ShadowScale, 3)
               .AddTile(TileID.DemonAltar)
               .Register();

        }

    }
}
