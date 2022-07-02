using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace BetterPreHardMode.Content.Tiles
{
    internal class CroniumOres : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 800;
            Main.tileShine2[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 350;

            AddMapEntry(new Color(255, 255, 255), CreateMapEntryName());

            DustType = DustID.Silver;
            ItemDrop = ModContent.ItemType<Items.Placebles.CroniumOre>();
            HitSound = SoundID.Tink;

            MineResist = 1.25f;
            MinPick = 40;



        }
    }
}
