using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public class Vegetables : IFruitsAndVegetables
    {
        public bool IsSpoiled { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
}
