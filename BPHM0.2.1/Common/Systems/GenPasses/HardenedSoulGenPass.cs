using Terraria;
using Terraria.ModLoader;
using BetterPreHardMode.Content.Tiles;
using Terraria.IO;
using Terraria.WorldBuilding;
using Terraria.ID;

namespace BetterPreHardMode.Common.Systems.GenPasses
{
    internal class HardenedSoulGenPass : GenPass
    {
        public HardenedSoulGenPass(string name, float weight) : base(name, weight) { }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Hardening The Worlds Souls";

            // Hardened Souls
            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            for (int i = 0; i < maxToSpawn; i++)
            {
                int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurface, Main.maxTilesY - 450);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 5), WorldGen.genRand.Next(2, 5), ModContent.TileType<HardenedSoul>());
            }

            //Souls For Ice
            maxToSpawn = WorldGen.genRand.Next(90, 240);
            int numSpawned = 0;
            int tries = 0;
            while (numSpawned < maxToSpawn)

            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next(0, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if (tile.TileType == TileID.SnowBlock || tile.TileType == TileID.IceBlock || tile.TileType == TileID.Slush)
                {
                    WorldGen.TileRunner(x, y, WorldGen._genRand.Next(2, 5), WorldGen.genRand.Next(1, 4), ModContent.TileType<HardenedSoul>());
                    numSpawned++;
                }

                tries++;
                if (tries > +100000)
                {
                    break;
                }
            }
        }
    }
}

