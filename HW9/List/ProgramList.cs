using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.List
{
    class ProgramList
    {
        private static List<int> wholeNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static List<string> words = new List<string>() { "phone", "computer", "plane", "tablet", "light" };

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        private static void Task1()
        {
            var n = new List<int> { 1, 2, 3, 4, 5 };
            var result = n.Where(i => i % 2 == 0).Sum();
            Console.WriteLine(result);
        }

        private static void Task2()
        {
            Console.WriteLine($"Numbers: {wholeNumbers.Count}");
        }

        private static void Task3()
        {
            foreach (var i in words)
            {
                if (i.Length == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Task4()
        {
            var selectedWords = from a in words
                                where a.Length == 5
                                select a;
            foreach (var i in selectedWords) { Console.WriteLine(i); }
        }
    }
}
