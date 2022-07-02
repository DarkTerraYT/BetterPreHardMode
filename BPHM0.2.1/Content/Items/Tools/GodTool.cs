using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Tools
{
    internal class GodTool : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("God Tool");
            Tooltip.SetDefault("You Have The Power Of God");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 1;
            Item.useAnimation = 1;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 5000;
            Item.knockBack = 2f;

            Item.value = Item.buyPrice(0, 0, 10, 0);
            Item.rare = ItemRarityID.Blue;

            Item.axe = 1000;
            Item.hammer = 5000;
            Item.pick = 5000;


        }
    }
}