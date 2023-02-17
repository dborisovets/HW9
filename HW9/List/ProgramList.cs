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

        private static void Task3() => _words.Where(str => str.Length == 5).ToList().ForEach(str => Console.WriteLine(str));

        private static void Task4()
        {
            var selectedWords = _words.Where(word => word.Length == 5);

            foreach (var word in selectedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}