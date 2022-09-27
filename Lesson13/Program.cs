using System;
using System.Collections.Generic;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeMethod();
            TestMethod();
        }

        static void PracticeMethod()
        {
            List<int> _list = new List<int>();

            var _rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                _list.Add(_rand.Next(-100, 101));
            }

            int _min = int.MaxValue, _max = int.MinValue;

            foreach (var el in _list)
            {
                Console.Write(el + " , ");

                _max = Math.Max(_max, el);
                _min = Math.Min(_min, el);
            }
            Console.WriteLine("\n" + _min + "\n" + _max);
            Console.WriteLine("\n" + "\n");

            _list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    _list.Add(10);
                }
                else _list.Add(0);
            }

            foreach (var el in _list) Console.WriteLine(el);
            Console.WriteLine("\n" + "\n");


            var _dic = new Dictionary<int, string>();

            while (_dic.Count < 30)
            {
                var _val = _rand.Next(0, 2000);
                _dic.TryAdd(_val, _val.ToString());
            }

            foreach (var el in _dic) Console.WriteLine(el.Value);
            Console.WriteLine("\n" + "\n");


            int[,] _array = new int[5, 5];

            for (int i = 0, j = 0; i < 5; i++)
            {
                for (; j < 5; j++)
                {
                    _array[i, j] = 1 * i * j;
                }
                j = 0;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(_array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void TestMethod()
        {
            List<int> _list = new List<int>;

            Random _rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                _list.Add(_rand.Next(-10, 10));
                    }
        }
    }
}
