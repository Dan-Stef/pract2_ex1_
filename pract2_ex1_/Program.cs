using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            if (x * x + y * y < 15 * 15 && y > Math.Abs(x))
                Console.WriteLine("Да");
            else if (x * x + y * y <= 15 * 15 && y == Math.Abs(x) || x * x + y * y == 15 * 15 && y > Math.Abs(x))
                Console.WriteLine("На границе");
            else Console.WriteLine("Нет");
            Console.ReadKey();
        }
    }
}
