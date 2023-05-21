using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StonePlate.Models
{
    public class Slab
    {
        // ID 
        public int SlabId { get; set; }
        // Left edge
        public int edgeL { get; set; }
        // right edge
        public int edgeR { get; set; }
    }
}