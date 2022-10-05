using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count = 0;
        public int Capacity { get { return _data.Length; } }

        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; ++i)
                    newArray[i] = _data[i];
                _data = newArray;
            }

            _data[Count] = item;
            Count++;
        }

        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; ++i)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T);

            Count--;
        }
    }

    class Board
    {
        public MyList<int> _data = new MyList<int>();

        public void Initialize()
        {
            _data.Add(101);
            _data.Add(102);
            _data.Add(103);
            _data.Add(104);
            _data.Add(105);

            int temp = _data[2];

            _data.RemoveAt(2);
        }

        static void Main(String[] args)
        {
            Board board = new Board();
            board.Initialize();
        }
    }
}
