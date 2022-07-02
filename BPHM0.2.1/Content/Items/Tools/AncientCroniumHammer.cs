using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Tools
{
    internal class AncientCroniumHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 13;
            Item.useAnimation = 13;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 6;
            Item.knockBack = 2f;

            Item.value = Item.buyPrice(0, 2, 4, 0);
            Item.rare = ItemRarityID.Blue;

            Item.hammer = 75;


        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 8)
                .AddIngredient(ModContent.ItemType<AncientCroniumBar>(), 12)
                .AddTile(ModContent.TileType<Content.Tiles.AncientForge>())
                .Register();
        }
    }
}
