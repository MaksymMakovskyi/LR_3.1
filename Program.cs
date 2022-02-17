using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F;
        m2:
            Console.WriteLine(" Введiть X: ");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine(" Введiть Y: ");
            float y = float.Parse((Console.ReadLine()));
            if (Math.Pow(x, 2) + Math.Max(Math.Pow(y, 3), x) != 0)
            {
                F = Math.Min(x, Math.Pow(x + y, 2)) / (Math.Pow(x, 2) + Math.Max(Math.Pow(y, 3), x));
                Console.WriteLine('\t' + " Результат:");
                Console.WriteLine("F = " + F);
            }
            else
            {
                Console.WriteLine(" На нуль дiлити не можна ");
            }
            Console.WriteLine('\n' + " Для повторного вводу натиснiть будь-яку клавiшу " + '\n' + " Для завершення програми натиснiть Enter.");
            string p = Console.ReadLine();
            if (p != "") goto m2;
        }
    }
}
