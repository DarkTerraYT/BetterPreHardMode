using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Tools
{
    internal class BrassMultiTool : ModItem
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
            Item.damage = 5;
            Item.knockBack = 2f;

            Item.value = Item.buyPrice(0, 0, 10, 0);
            Item.rare = ItemRarityID.Blue;

            Item.axe = 10;
            Item.hammer = 50;
            Item.pick = 55;


        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BrassPickaxe>(), 1)
                .AddIngredient(ModContent.ItemType<BrassAxe>(), 1)
                .AddIngredient(ModContent.ItemType<BrassHammer>(), 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}