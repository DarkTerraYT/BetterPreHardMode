using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items
{

    internal class EmpoweredSoulItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empowered Soul");
            Tooltip.SetDefault("Empowered Souls Can Do Great And Bad Things...");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 51;
        }


        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(0, 3, 0, 0);
            Item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<SoulItem>(), 4)
                .AddTile(ModContent.TileType<Content.Tiles.SoulEmpowerer>())
                .Register();
        }
    }
}