using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StonePlate.Models
{
    public class Tile
    {
        // ID 
        public int TileId { get; set; }
        // 
        public int xLen { get; set; }
        // 
        public int yLen { get; set; }
        // ID книги
        public int quantity { get; set; }

    }
}