using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.List
{
    class ProgramList
    {
        private static List<int> _wholeNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static List<string> _words = new List<string>() { "phone", "computer", "plane", "tablet", "light" };

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        private static void Task1()
        {
            List<int> _n = new() { 1, 2, 3, 4, 5 };
            var result = _n.Sum(i => (i % 2 == 0) ? i : 0);
            Console.WriteLine(result);
        }

        private static void Task2() => Console.WriteLine($"Numbers: {_wholeNumbers.Count}");

        private static void Task3()
        {
            foreach (var str in _words.Where(str => str.Length == 5)) Console.WriteLine(str);
        }

        private static void Task4()
        {
            foreach (var selectedWords in from a in _words
                                          where a.Length == 5
                                          select a) Console.WriteLine(selectedWords);
        }
    }
}
