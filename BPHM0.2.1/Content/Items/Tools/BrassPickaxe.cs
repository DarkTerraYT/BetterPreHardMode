using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;


namespace BetterPreHardMode.Content.Items.Tools;

internal class BrassPickaxe : ModItem
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
        Item.useAnimation = 15;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTurn = true;

        Item.DamageType = DamageClass.Melee;
        Item.damage = 3;
        Item.knockBack = 2f;

        Item.value = Item.buyPrice(0, 0, 10, 0);
        Item.rare = ItemRarityID.Blue;

        Item.pick = 55;


    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddRecipeGroup(RecipeGroupID.Wood, 8)
            .AddIngredient(ModContent.ItemType<CroniumBar>(), 12)
            .AddTile(TileID.Anvils)
            .Register();
    }
}