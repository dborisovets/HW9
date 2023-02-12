using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW9.Queue_and_Stack
{
    class ProgramQueue
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task1()
        {
            Queue<int> dasha = new Queue<int>();
            var _value = "0";
            do
            {
                _value = Console.ReadLine();
                int result = Int32.Parse(_value);
                dasha.Enqueue(result);
            }
            while (!"0".Equals(_value));

            int _maxValue = getMaxValue(dasha);

            Console.WriteLine(_maxValue);

            dasha.Dequeue();
            _maxValue = getMaxValue(dasha);
            Console.WriteLine(_maxValue);
        }

        private static int getMaxValue(Queue<int> queueWithInt)
        {
            int _maxValue = Int32.MinValue;
            foreach (int item in queueWithInt)
            {
                if (item > _maxValue) { _maxValue = item; }
            }
            return _maxValue;
        }

        private static void Task2()
        {
            Stack<char> _letters = new Stack<char>();
            for (int i = 0; i < 3; i++)
            {
                string value = Console.ReadLine();
                char letter = value.ToCharArray()[0];
                _letters.Push(letter);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(_letters.Pop());
            }
        }
    }
}





