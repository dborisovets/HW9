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
            Queue<int> queue = new Queue<int>();
            string value = "0";
            do
            {
                value = Console.ReadLine();
                int result = Int32.Parse(value);
                queue.Enqueue(result);
            }
            while (!"0".Equals(value));

            int maxValue = getMaxValue(queue);

            Console.WriteLine(maxValue);

            queue.Dequeue();
            maxValue = getMaxValue(queue);
            Console.WriteLine(maxValue);
        }

        private static int getMaxValue(Queue<int> queueWithInt)
        {
            int maxValue = Int32.MinValue;
            foreach (int item in queueWithInt)
            {
                if (item > maxValue) { maxValue = item; }
            }
            return maxValue;
        }

        private static void Task2()
        {
            Stack<char> letters = new Stack<char>();
            for (int i = 0; i < 3; i++)
            {
                string value = Console.ReadLine();
                char letter = value.ToCharArray()[0];
                letters.Push(letter);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(letters.Pop());
            }
        }
    }
}





