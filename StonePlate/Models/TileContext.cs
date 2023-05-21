using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StonePlate.Models
{
    public class TileContext : DbContext
    {
        public DbSet<Slab> Slabs { get; set; }
        public DbSet<Tile> Tiles { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Cutting> Cuttings { get; set; }
        public DbSet<Graph> Graphs { get; set; }
    }
}
