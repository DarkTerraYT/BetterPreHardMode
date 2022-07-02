using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace BetterPreHardMode.Content.Items.Weapons
{
    internal class SoulSword : ModItem
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
            Item.damage = 10;
            Item.knockBack = 5f;
            Item.crit = 5;


            //Misc
            Item.value = Item.buyPrice(0, 0, 5, 0);
            Item.rare = ItemRarityID.Blue;

            //Sounds
            Item.UseSound = SoundID.Item1;



        }

        // Adds a recipe
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<SoulItem>(), 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }

}
