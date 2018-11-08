using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriqueDemo
{
    class Alea<T>
    {
        private List<T> items = new List<T>();

        public void add(T obj)
        {
            items.Add(obj);
        }

        public T getAleaUnique()
        {
            int no = (new Random()).Next(0, items.Count);
            T temp = items[no];
            items.Remove(items[no]);
            return temp;
        }

        public T getAlea()
        {
            int no = (new Random()).Next(0, items.Count);
            return items[no];
        }
    }
}
