using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class MyArray<T> : IEnumerable<T>
    {
        T[] data;
        int count;
        public T this[int idx]
        {
            set { data[idx] = value; }
            get { return data[idx]; }
        }

        public int Count
        {
            get { return count; }
        }
        public MyArray(int size)
        {
            data = new T[size];
            count = 0;

        }
        public MyArray() : this(20) { }

        public void Add(T item)
        {
            data[count++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return data[i];
            }

        }

        public class MyArray1<T> : MyArray<T> { }
        public class MyArray2 : MyArray<string> { }


    }
}