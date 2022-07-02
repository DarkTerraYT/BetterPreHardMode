
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Weapons
{
    internal class AncientCroniumSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 32;
            Item.height = 32;

            // Animation
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;


            // Makes The Sword Work

            Item.DamageType = DamageClass.Melee;
            Item.damage = 23;
            Item.knockBack = 5f;
            Item.crit = 5;


            //Misc
            Item.rare = ItemRarityID.Blue;



        }

        // Adds a recipe
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<AncientCroniumBar>(), 8)
                .AddTile(ModContent.TileType<Content.Tiles.AncientForge>())
                .Register();
        }
    }

}
