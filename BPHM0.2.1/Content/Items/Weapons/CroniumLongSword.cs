using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Projectiles.Weapons;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Weapons
{
    internal class CroniumLongSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 64;
            Item.height = 64;

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

            //Projectile
            Item.shootSpeed = 52.5f;
            Item.shoot = ModContent.ProjectileType<MagicEmeraldProjectile>();



        }

        // Adds a recipe
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<CroniumBar>(), 18)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }

}
