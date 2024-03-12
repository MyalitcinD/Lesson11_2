using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение для b и для k для уровнения 0=kx+b");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Equation equation = new Equation(k, b);
            double root = equation.Root();
            Console.WriteLine("Результат вычисления корная уравнения x = {0}", root);
            Console.ReadKey();

        }
    }
}
