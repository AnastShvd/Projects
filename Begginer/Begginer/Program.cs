using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begginer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевод М в КМ\n\nВведите число (в М), которое нужно перевести в КМ: \n");
            float n = Convert.ToInt32(Console.ReadLine());
            float m = n / 1000;
            Console.WriteLine("{0} метров это {1} километров", n, m);
         

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Деление числа на разряды\n\nВведите 4хзначное число: \n");
            int r = Convert.ToInt32(Console.ReadLine());
            int e = r % 10;
            int d = r % 100; int d2 = d / 10; 
            int s = r % 1000; int s2 = s / 100; 
            int t = r / 1000;
            Console.WriteLine("В этом числе {0} единиц, {1} десятков, {2} сотен и {3} тысяч", e, d2, s2, t);        

            Console.ReadLine();
        }
    }
}
