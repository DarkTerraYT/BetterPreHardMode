using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace BetterPreHardMode.Content.Items.Placebles
{
    internal class HardenedSoulItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hardened Soul");
            Tooltip.SetDefault("Rocky Souls? Cool!");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 50;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(copper: 75);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<Tiles.HardenedSoul>();
            Item.placeStyle = 0;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<SoulItem>(), 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
