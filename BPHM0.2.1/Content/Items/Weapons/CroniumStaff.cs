using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BetterPreHardMode.Content.Items.Projectiles.Weapons;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Weapons
{
    internal class CroniumStaff : ModItem
    {
        public override void SetStaticDefaults()
        {

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.damage = 35;
            Item.mana = 9;
            Item.knockBack = 3.2f;

            Item.useTime = 20;
            Item.useAnimation = 15;

            Item.UseSound = SoundID.Item71;

            Item.shoot = ModContent.ProjectileType<CroniumStaffProjectile>();
            Item.shootSpeed = 1f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<CroniumBar>(), 10)
                .AddIngredient(ModContent.ItemType<Jade>(), 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
