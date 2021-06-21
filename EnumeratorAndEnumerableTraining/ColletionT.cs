using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorAndEnumerableTraining
{
    public class ColletionT : ICollection<string>
    {
        string _imie { get; set; }
        string _nazwisko { get; set; }
        DateTime _dataUrodzenia { get; set; }
        Collection<string> additionalData = new Collection<string>();
        public ColletionT(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _dataUrodzenia = dataUrodzenia;
        }
        public int Count => 3;

        bool ICollection<string>.IsReadOnly => false;

        public void Add(string item)
        {
            additionalData.Add(item);
        }

        public void Clear()
        {
            additionalData = new Collection<string>();
        }

        public bool Contains(string item)
        {
            if (item == _nazwisko || item == _imie || item == _dataUrodzenia.ToString("D"))
                return true;

            return false;
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetEnumerator()
        {
            yield return _imie;
            yield return _nazwisko;
            yield return _dataUrodzenia.ToString("D");
            foreach (var item in additionalData)
            {
                yield return item;
            }
        }

        public bool Remove(string item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
