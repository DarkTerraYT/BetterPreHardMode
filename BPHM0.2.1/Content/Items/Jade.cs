using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;



namespace BetterPreHardMode.Content.Items
{
    internal class Jade : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(silver: 50);
            Item.maxStack = 999;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Emerald, 1)
                .AddIngredient(ItemID.Gel, 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
