using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StonePlate.Models
{
    public class Graph
    {
        // ID 
        public int GraphId { get; set; }
        // Left edge
        public int edgeL1 { get; set; }
        public int edgeL2 { get; set; }
        // right edge
        public int edgeR1 { get; set; }
        public int edgeR2 { get; set; }
        // Y
        public int egY1 { get; set; }
        public int egY2 { get; set; }
    }
}