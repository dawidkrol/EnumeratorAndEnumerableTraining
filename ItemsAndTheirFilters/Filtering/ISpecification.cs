using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public interface ISpecification<T>
    {
        bool IsSatisfying(T t);
    }
}
