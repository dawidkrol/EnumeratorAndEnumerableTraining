using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public interface IFlat : IItem
    {
        int SquareMeters { get; set; }
        int Floor { get; set; }
    }
}
