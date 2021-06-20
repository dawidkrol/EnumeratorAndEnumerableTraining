using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public class Flats : IFlat
    {
        public int SquareMeters { get; set; }
        public int Floor { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
}
