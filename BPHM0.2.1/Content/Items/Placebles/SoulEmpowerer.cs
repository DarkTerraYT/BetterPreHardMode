using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Placebles
{
    internal class SoulEmpowerer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Empowerer");
            Tooltip.SetDefault("Used To Empowerer Souls.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            ItemID.Sets.SortingPriorityMaterials[Type] = 60;

        }

        public override void SetDefaults()
        {
            Item.width = 36;
            Item.height = 24;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(gold: 2, silver: 30);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<Tiles.SoulEmpowerer>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<HardenedSoulItem>(), 5)
                .AddIngredient(ItemID.MoneyTrough, 1)
                .AddTile(TileID.Anvils)
                .Register();

            CreateRecipe()
               .AddIngredient(ModContent.ItemType<SoulItem>(), 5)
               .AddIngredient(ItemID.MoneyTrough, 1)
               .AddTile(TileID.Anvils)
               .Register();

        }

    }
}
