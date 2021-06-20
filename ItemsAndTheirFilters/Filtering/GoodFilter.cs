using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public class GoodFilter : IFilter<Color,IItem>
    {
        public IEnumerable<IItem> FilterBy(IEnumerable<IItem> _init, ISpecification<Color> _spec)
        {
            foreach (var item in _init)
            {
                if(_spec.IsSatisfying(item.Color))
                {
                    yield return item;
                }
            }
        }
    }
}
