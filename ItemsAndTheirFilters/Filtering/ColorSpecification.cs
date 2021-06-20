using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndTheirFilters
{
    public class ColorSpecification : ISpecification<Color>
    {
        Color _color { get; set; }
        public ColorSpecification(Color color)
        {
            _color = color;
        }
        public bool IsSatisfying(Color color)
        {
            if(color == _color)
            {
                return true;
            }
            return false;
        }
    }
}
