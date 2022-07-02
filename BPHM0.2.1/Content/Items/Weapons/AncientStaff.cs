using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BetterPreHardMode.Content.Items.Projectiles.Weapons;
using Terraria.GameContent.Creative;
using BetterPreHardMode.Content.Items.Placebles;

namespace BetterPreHardMode.Content.Items.Weapons
{
    internal class AncientStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Staff Of The Ancients");
            Tooltip.SetDefault("Used By The Ancient To Do Massive Ammount OF Damage!" +
                " This Is Really Expensive.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.damage = 56;
            Item.mana = 12;
            Item.knockBack = 3.2f;

            Item.useTime = 20;
            Item.useAnimation = 15;

            Item.UseSound = SoundID.Item19;

            Item.shoot = ModContent.ProjectileType<AncientShuriken>();
            Item.shootSpeed = 1f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<EmpoweredSoulItem>(), 10)
                .AddIngredient(ModContent.ItemType<AncientCroniumBar>(), 12)
                .AddTile(ModContent.TileType<Tiles.SoulEmpowerer>())
                .Register();
        }
    }
}

