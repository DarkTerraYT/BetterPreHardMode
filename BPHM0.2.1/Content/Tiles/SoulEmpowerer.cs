using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using BetterPreHardMode.Content.Dusts;

namespace BetterPreHardMode.Content.Tiles
{
    internal class SoulEmpowerer : ModTile
    {

        public override void SetStaticDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileSolid[Type] = false;
            Main.tileNoAttach[Type] = true;
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.AvoidedByNPCs[Type] = false;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
        }

        public override void NumDust(int i, int j, bool fail, ref int num) => num = Main.rand.Next(1, 3);

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];

            // Make it emit the following light.
            r = 0;
            g = 0.8f;
            b = 0.3f;
            var dust = ModContent.DustType<SoulDust>();
            DustType = dust;
            AddMapEntry(new Color(0, 255, 175), CreateMapEntryName());

            AdjTiles = new int[] { TileID.WorkBenches };
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 18 };
            TileObjectData.addTile(Type);
        }


        public override bool Drop(int x, int y)
        {
            Tile t = Main.tile[x, y];
            int style = t.TileFrameX / 18;

            switch (style)
            {
                case 0: Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 16, 16, ModContent.ItemType<Items.Placebles.SoulEmpowerer>()); break;


            }

            return base.Drop(x, y);
        }
    }
}
