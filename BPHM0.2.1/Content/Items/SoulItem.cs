using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items
{

    internal class SoulItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 51;
        }


        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(0, 0, 0, 80);
            Item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<HardenedSoulItem>(), 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}