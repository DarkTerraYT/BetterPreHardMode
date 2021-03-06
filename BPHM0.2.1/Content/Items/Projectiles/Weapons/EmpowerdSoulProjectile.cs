using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using BetterPreHardMode.Content.Dusts;

namespace BetterPreHardMode.Content.Items.Projectiles.Weapons
{
    internal class EmpowerdSoulProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            //Hitbox
            Projectile.width = 42;
            Projectile.height = 42;

            //Settings
            Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;

            //DamageClass
            Projectile.DamageType = DamageClass.Magic;

            //AI
            Projectile.aiStyle = -1;

            //Penetration
            Projectile.penetrate = 10;
        }

        public override void AI()
        {
            Projectile.ai[0]++;
            Projectile.alpha += 1;
            if (Projectile.ai[0] < 60f)
            {
                Projectile.velocity *= 1.01f;
            }
            else
            {
                Projectile.velocity *= 1.05f;
                if (Projectile.ai[0] == 180)
                {
                    Projectile.Kill();
                }
            }

            Projectile.rotation = Projectile.direction;

            Lighting.AddLight(Projectile.Center, 0f, 0.40f, 0.90f);

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
