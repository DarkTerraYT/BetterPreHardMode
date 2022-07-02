using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using BetterPreHardMode.Content.Dusts;

namespace BetterPreHardMode.Content.Items.Projectiles.Weapons
{
    internal class SoulProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 24;
            Projectile.height = 24;

            Projectile.friendly = true;
            Projectile.penetrate = 1;
            Projectile.tileCollide = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.ownerHitCheck = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 10000;

            Projectile.aiStyle = -1;

        }

        public override void AI()
        {

            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection;

            int halfProjWidth = Projectile.width / 2;
            int halfProjHeight = Projectile.height / 2;

            DrawOriginOffsetX = 0;
            DrawOffsetX = ((32 / 2) - halfProjWidth);
            DrawOriginOffsetY = ((32 / 2) - halfProjHeight / 2);

            Lighting.AddLight(Projectile.Center, 0f, 0.4f, 0.9f);


            if (Main.rand.NextBool(2))
            {
                int numToSpawn = Main.rand.Next(3);
                for (int i = 0; i < numToSpawn; i++)
                {
                    Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<SoulDust>(), Projectile.velocity.X * 0.1f, Projectile.velocity.Y * 0.1f,
                        0, default(Color), 1f);
                }
            }
        }


    }
}
