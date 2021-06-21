using ItemsAndTheirFilters;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumeratorAndEnumerableTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filter = new GoodFilter();
            //foreach (var item in filter.FilterBy(GetItems(),new ColorSpecification(Color.black)))
            //{
            //    Console.WriteLine(item.Name);
            //}

            EnumerableT vs = new EnumerableT("Dawid","Król",new DateTime(2001,04,22));
            //foreach (var item in vs)
            //{
            //    Console.WriteLine(item);
            //}

            //if(vs is IEnumerable coll)
            //{
            //    foreach (var item in coll)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            ColletionT vs1 = new ColletionT("Dawid", "Król", new DateTime(2001, 04, 22));
            Console.WriteLine(vs1.Contains("Dawid"));
            vs1.Add("dodatkowe1");
            vs1.Add("dodatkowe2");
            vs1.Add("dodatkowe3");
            vs1.Clear();
            foreach (var item in vs1)
            {
                Console.WriteLine(item);
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
