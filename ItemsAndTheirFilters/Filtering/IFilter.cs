using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public interface IFilter<T,K>
    {
        IEnumerable<K> FilterBy(IEnumerable<K> _init, ISpecification<T> _spec);
    }
}
