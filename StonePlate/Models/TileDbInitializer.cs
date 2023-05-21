using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace StonePlate.Models
{
    public class TileDbInitializer : DropCreateDatabaseAlways<TileContext>
    {
        protected override void Seed(TileContext db)
        {
            db.Tiles.Add(new Tile { xLen = 300, yLen = 400, quantity = 220 });
            db.Tiles.Add(new Tile { xLen = 400, yLen = 500, quantity = 180 });
            db.Tiles.Add(new Tile { xLen = 500, yLen = 600, quantity = 150 });
            db.Tiles.Add(new Tile { xLen = 600, yLen = 600, quantity = 250 });
            db.Tiles.Add(new Tile { xLen = 300, yLen = 600, quantity = 350 });


            db.Slabs.Add(new Slab { edgeL = 58, edgeR = 234 });
            db.Slabs.Add(new Slab { edgeL = 46, edgeR = 211 });
            db.Slabs.Add(new Slab { edgeL = 44, edgeR = 220 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 242 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 248 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 33, edgeR = 238 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 243 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 32, edgeR = 242 });
            db.Slabs.Add(new Slab { edgeL = 33, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 35, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 40, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 40, edgeR = 243 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 35, edgeR = 242 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 33, edgeR = 242 });
            db.Slabs.Add(new Slab { edgeL = 27, edgeR = 243 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 32, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 234 });
            db.Slabs.Add(new Slab { edgeL = 42, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 243 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 242 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 239 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 33, edgeR = 239 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 243 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 32, edgeR = 239 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 42, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 243 });
            db.Slabs.Add(new Slab { edgeL = 37, edgeR = 244 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 45, edgeR = 242 });
            db.Slabs.Add(new Slab { edgeL = 36, edgeR = 241 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 33, edgeR = 238 });
            db.Slabs.Add(new Slab { edgeL = 39, edgeR = 243 });
            db.Slabs.Add(new Slab { edgeL = 34, edgeR = 240 });
            db.Slabs.Add(new Slab { edgeL = 32, edgeR = 238 });
            db.Slabs.Add(new Slab { edgeL = 39, edgeR = 233 });
            db.Slabs.Add(new Slab { edgeL = 48, edgeR = 216 });
            db.Slabs.Add(new Slab { edgeL = 55, edgeR = 222 });
            db.Slabs.Add(new Slab { edgeL = 57, edgeR = 218 });



            db.Dimensions.Add(new Dimension { x1 = 240, y1 = 5, x2 = 360, y2 = 5 });
            db.Dimensions.Add(new Dimension { x1 = 232, y1 = 300, x2 = 360, y2 =300 });
            db.Dimensions.Add(new Dimension { x1 = 356, y1 = 5, x2 = 356, y2 = 300 });
            db.Dimensions.Add(new Dimension { x1 = 356-4, y1 = 5+4, x2 = 356+4, y2 = 5-4 });
            db.Dimensions.Add(new Dimension { x1 = 356 - 4, y1 = 300+4, x2 = 356+4, y2 = 300-4 });

            db.Dimensions.Add(new Dimension { x1 = 27, y1 = 225, x2 = 27, y2 = 400 });
            db.Dimensions.Add(new Dimension { x1 = 263, y1 = 235, x2 = 263, y2 = 400 });
            db.Dimensions.Add(new Dimension { x1 = 27, y1 =396, x2 = 263, y2 = 396 });
            db.Dimensions.Add(new Dimension { x1 = 27-4, y1 = 396+4, x2 = 27+4, y2 = 396-4 });
            db.Dimensions.Add(new Dimension { x1 = 263-4, y1 = 396+4, x2 = 263+4, y2 = 396-4 });


            db.Graphs.Add(new Graph { edgeL1 = 51, edgeL2 = 51, edgeR1 = 51, edgeR2 = 240, egY1 = 5, egY2 = 5 });
            db.Graphs.Add(new Graph { edgeL1 = 51, edgeL2 = 49, edgeR1 = 240, edgeR2 = 245, egY1 = 5, egY2 = 10 });
            db.Graphs.Add(new Graph { edgeL1 = 49, edgeL2 = 35, edgeR1 = 245, edgeR2 = 253, egY1 = 10, egY2 = 15 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 37, edgeR1 = 253, edgeR2 = 252, egY1 = 15, egY2 = 20 });
            db.Graphs.Add(new Graph { edgeL1 = 37, edgeL2 = 33, edgeR1 = 252, edgeR2 = 254, egY1 = 20, egY2 = 25 });
            db.Graphs.Add(new Graph { edgeL1 = 33, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 25, egY2 = 30 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 30, egY2 = 35 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 35, egY2 = 40 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 40, egY2 = 45 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 45, egY2 = 50 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 50, egY2 = 55 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 55, egY2 = 60 });;
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 27, edgeR1 = 252, edgeR2 = 254, egY1 = 60, egY2 = 65 });
            db.Graphs.Add(new Graph { edgeL1 = 27, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 65, egY2 = 70 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 70, egY2 = 75 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 75, egY2 = 80 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 80, egY2 = 85 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 85, egY2 = 90 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 90, egY2 = 95 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 95, egY2 = 100 });
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 27, edgeR1 = 252, edgeR2 = 254, egY1 = 100, egY2 = 105 });
            db.Graphs.Add(new Graph { edgeL1 = 27, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 105, egY2 = 110 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 110, egY2 = 115 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 115, egY2 = 120 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 120, egY2 = 125 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 125, egY2 = 130 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 130, egY2 = 135 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 135, egY2 = 140 });
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 27, edgeR1 = 252, edgeR2 = 254, egY1 = 140, egY2 = 145 });
            db.Graphs.Add(new Graph { edgeL1 = 27, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 145, egY2 = 150 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 150, egY2 = 155 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 155, egY2 = 160 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 160, egY2 = 165 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 165, egY2 = 170 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 170, egY2 = 175 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 175, egY2 = 180 });
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 27, edgeR1 = 252, edgeR2 = 254, egY1 = 180, egY2 = 185 });
            db.Graphs.Add(new Graph { edgeL1 = 27, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 185, egY2 = 190 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 190, egY2 = 195 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 195, egY2 = 200 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 200, egY2 = 205 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 205, egY2 = 210 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 210, egY2 = 215 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 215, egY2 = 220 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 135, egY2 = 140 });
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 27, edgeR1 = 252, edgeR2 = 254, egY1 = 140, egY2 = 145 });
            db.Graphs.Add(new Graph { edgeL1 = 27, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 145, egY2 = 150 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 150, egY2 = 155 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 155, egY2 = 160 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 160, egY2 = 165 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 165, egY2 = 170 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 170, egY2 = 175 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 175, egY2 = 180 });
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 27, edgeR1 = 252, edgeR2 = 254, egY1 = 180, egY2 = 185 });
            db.Graphs.Add(new Graph { edgeL1 = 27, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 185, egY2 = 190 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 190, egY2 = 195 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 195, egY2 = 200 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 200, egY2 = 205 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 205, egY2 = 210 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 210, egY2 = 215 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 215, egY2 = 220 });
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 27, edgeR1 = 252, edgeR2 = 254, egY1 = 220, egY2 = 225 });
            db.Graphs.Add(new Graph { edgeL1 = 27, edgeL2 = 29, edgeR1 = 254, edgeR2 = 258, egY1 = 225, egY2 = 230 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 263, egY1 = 230, egY2 = 235 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 42, edgeR1 = 263, edgeR2 = 253, egY1 = 235, egY2 = 240 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 35, edgeR1 = 253, edgeR2 = 256, egY1 = 240, egY2 = 245 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 29, edgeR1 = 256, edgeR2 = 258, egY1 = 245, egY2 = 250 });
            db.Graphs.Add(new Graph { edgeL1 = 29, edgeL2 = 35, edgeR1 = 258, edgeR2 = 260, egY1 = 250, egY2 = 255 });
            db.Graphs.Add(new Graph { edgeL1 = 35, edgeL2 = 32, edgeR1 = 260, edgeR2 = 252, egY1 = 255, egY2 = 260 });
            db.Graphs.Add(new Graph { edgeL1 = 32, edgeL2 = 37, edgeR1 = 252, edgeR2 = 254, egY1 = 260, egY2 = 265 });
            db.Graphs.Add(new Graph { edgeL1 = 37, edgeL2 = 39, edgeR1 = 254, edgeR2 = 258, egY1 = 265, egY2 = 270 });
            db.Graphs.Add(new Graph { edgeL1 = 39, edgeL2 = 45, edgeR1 = 258, edgeR2 = 251, egY1 = 270, egY2 = 275 });
            db.Graphs.Add(new Graph { edgeL1 = 45, edgeL2 = 42, edgeR1 = 251, edgeR2 = 253, egY1 = 275, egY2 = 280 });
            db.Graphs.Add(new Graph { edgeL1 = 42, edgeL2 = 45, edgeR1 = 253, edgeR2 = 256, egY1 = 280, egY2 = 285 });
            db.Graphs.Add(new Graph { edgeL1 = 45, edgeL2 = 49, edgeR1 = 256, edgeR2 = 239, egY1 = 285, egY2 = 290 });
            db.Graphs.Add(new Graph { edgeL1 = 49, edgeL2 = 45, edgeR1 = 239, edgeR2 = 238, egY1 = 290, egY2 = 295 });
            db.Graphs.Add(new Graph { edgeL1 = 45, edgeL2 = 52, edgeR1 = 238, edgeR2 = 232, egY1 = 295, egY2 = 300 });
            db.Graphs.Add(new Graph { edgeL1 = 52, edgeL2 = 52, edgeR1 = 52, edgeR2 = 232, egY1 = 300, egY2 = 300 });
            base.Seed(db);
        }
    }
}