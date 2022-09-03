using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
        }
    }
    class MyList<T> // Generic class
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array= new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i= 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }
        

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}