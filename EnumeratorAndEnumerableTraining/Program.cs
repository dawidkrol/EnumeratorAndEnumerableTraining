using ItemsAndTheirFilters;
using System;
using System.Collections.Generic;

namespace EnumeratorAndEnumerableTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new GoodFilter();
            foreach (var item in f.FilterBy(GetItems(),new ColorSpecification(Color.black)))
            {
                Console.WriteLine(item.Name);
            }
        }
        static List<IItem> GetItems()
        {
            List<IItem> output = new List<IItem>();
            output.Add(new Flats { Color = Color.black, Size = Size.Huge, Name = "Złota 44" });
            output.Add(new Flats { Color = Color.green, Size = Size.Small, Name = "Małe mieszkanie" });
            output.Add(new Fruits { Name = "Apple", Size = Size.Medium, Color = Color.black });
            output.Add(new Fruits { Name = "Orange", Size = Size.Large, Color = Color.orange });
            output.Add(new Vegetables { Name = "Tomato", Size = Size.Medium, Color = Color.black });

            return output;
        }
    }
}
