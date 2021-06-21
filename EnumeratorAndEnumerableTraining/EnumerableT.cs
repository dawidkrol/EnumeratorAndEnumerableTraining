using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorAndEnumerableTraining
{
    public class EnumerableT : IEnumerable<string>
    {
        string _imie { get; set; }
        string _nazwisko { get; set; }
        DateTime _dataUrodzenia { get; set; }
        public EnumerableT(string imie,string nazwisko,DateTime dataUrodzenia)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _dataUrodzenia = dataUrodzenia;
        }
        //string[] dane = { "dawid", "król", "2001", "2021" };
        public IEnumerator<string> GetEnumerator()
        {
            yield return _imie;
            yield return _nazwisko;
            yield return _dataUrodzenia.ToString("D");
            //foreach (var item in dane)
            //{
            //    yield return item;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
