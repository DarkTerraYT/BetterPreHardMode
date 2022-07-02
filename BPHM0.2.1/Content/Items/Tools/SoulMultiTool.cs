using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace BetterPreHardMode.Content.Items.Tools
{
    internal class SoulMultiTool : ModItem
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
            Item.damage = 7;
            Item.knockBack = 2f;

            Item.value = Item.buyPrice(0, 0, 10, 0);
            Item.rare = ItemRarityID.Blue;

            Item.axe = 12;
            Item.hammer = 50;
            Item.pick = 60;


        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<SoulPickaxe>(), 1)
                .AddIngredient(ModContent.ItemType<SoulAxe>(), 1)
                .AddIngredient(ModContent.ItemType<SoulHammer>(), 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}