using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class SimpleGeneric<T>
    {
        private T[] values;
        private int index;

        public SimpleGeneric(int len)
        {
            values = new T[len];
            index = 0;
        }

        public void Add(params T[] args)
        {
            foreach (T item in args)
            {
                values[index++] = item;
            }
        }
        public void Print()
        {
            foreach (T item in values)
            {
                Console.WriteLine(item + ",");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeneric<Int32> ginterger = new SimpleGeneric<int>(10);
            SimpleGeneric<double> gDouble = new SimpleGeneric<double>(10);

            ginterger.Add(1, 2);
            ginterger.Add(1, 2, 3, 4, 5, 6, 7);
            ginterger.Add(10);

            gDouble.Add(10.0, 12.4, 37.5);
            ginterger.Print();
            gDouble.Print();

        }
    }
}
