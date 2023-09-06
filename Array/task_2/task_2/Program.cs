using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1: ");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            float y2 = float.Parse(Console.ReadLine());

            line_length line = new line_length(x1, y1, x2, y2);
            float length = line.find_length();

            Console.WriteLine("The length of the line is: " + length);
        }
    }
}
