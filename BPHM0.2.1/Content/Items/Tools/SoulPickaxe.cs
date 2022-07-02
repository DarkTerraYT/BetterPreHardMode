using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;


namespace BetterPreHardMode.Content.Items.Tools;

internal class SoulPickaxe : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Soul Pickaxe");
        Tooltip.SetDefault("Souly!");
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
        Item.damage = 5;
        Item.knockBack = 2f;

        Item.value = Item.buyPrice(0, 0, 10, 0);
        Item.rare = ItemRarityID.Blue;

        Item.pick = 60;


    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddRecipeGroup(RecipeGroupID.Wood, 8)
            .AddIngredient(ModContent.ItemType<SoulItem>(), 12)
            .AddTile(TileID.Anvils)
            .Register();
    }
}
