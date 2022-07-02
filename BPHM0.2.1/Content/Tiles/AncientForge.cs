using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using BetterPreHardMode.Content.Dusts;

namespace BetterPreHardMode.Content.Tiles
{
    internal class AncientForge : ModTile
    {

        public override void SetStaticDefaults()
        {
            Main.tileTable[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileNoAttach[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.AvoidedByNPCs[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            var dust = ModContent.DustType<CroniumSparkle>();
            DustType = dust;
            AddMapEntry(new Color(125, 125, 125), CreateMapEntryName());

            AdjTiles = new int[] { TileID.Anvils };
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
                case 0: Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 16, 16, ModContent.ItemType<Items.Placebles.AncientForge>()); break;


            }

            return base.Drop(x, y);
        }
    }
}
