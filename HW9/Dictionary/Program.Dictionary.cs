using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithDictionary();
        }

        private static void WorkWithDictionary()
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            map.Add("Dasha", 30);
            map["Petya"] = 35;
            Console.WriteLine(map["Dasha"]);
        }
    }
}
