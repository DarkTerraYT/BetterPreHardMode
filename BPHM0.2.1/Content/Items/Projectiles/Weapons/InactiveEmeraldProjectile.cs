using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace BetterPreHardMode.Content.Items.Projectiles.Weapons
{
    internal class MagicEmeraldProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 36;
            Projectile.height = 36;

            Projectile.friendly = true;
            Projectile.penetrate = 2;
            Projectile.tileCollide = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.ownerHitCheck = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 10000;

            Projectile.aiStyle = ProjAIStyleID.GemStaffBolt;

        }

        public override void AI()
        {
            base.AI();

            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection;

            int halfProjWidth = Projectile.width / 2;
            int halfProjHeight = Projectile.height / 2;

            DrawOriginOffsetX = 0;
            DrawOffsetX = ((32 / 2) - halfProjWidth);
            DrawOriginOffsetY = ((32 / 2) - halfProjHeight / 2);
        }
    }
}