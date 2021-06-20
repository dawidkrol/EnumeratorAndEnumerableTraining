using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public interface IItem
    {
        string Name { get; set; }
        Color Color { get; set; }
        Size Size { get; set; }
    }
}
