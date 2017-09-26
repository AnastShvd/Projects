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
            //первая задача_перевод м в км

            Console.WriteLine("Перевод М в КМ\n\nВведите число (в М), которое нужно перевести в КМ:");
            double n = Convert.ToDouble(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("\nНедопустимый формат. Введите чиcло ещё раз:");
                n = Convert.ToDouble(Console.ReadLine());
            }
            if (n > 0)
            {
                double m = n / 1000;
                Console.WriteLine("\n{0} метров это {1} километров", n, m);
            }

            //вторая задача_деление числа на разряды

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Деление числа на разряды\n\nВведите 4хзначное число:");
            double r = Convert.ToDouble(Console.ReadLine());
            while ((r % 1 != 0)||(r > 9999)||(r < 1000))
            {
                Console.WriteLine("\nНедопустимый формат. Введите число ещё раз:");
                r = Convert.ToDouble(Console.ReadLine());
            }
            if ((r % 1 == 0) && (r <= 9999) && (r >= 1000))
            {
                double e = r % 10;

                double d = r % 100;
                int d2 = Convert.ToInt32(d);
                int d3 = d2 / 10;

                double s = r % 1000;
                int s2 = Convert.ToInt32(s);
                int s3 = s2 / 100;

                double t = r / 1000;
                int t2 = Convert.ToInt32(t);


                Console.WriteLine("\nВ этом числе {0} единиц, {1} десятков, {2} сотни и {3} тысяч", e, d3, s3, t2);
            }

            //третья задача_решение формулы
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Решение формулы\n\nВведите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите f: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double otvet = (a + b - (f / a)) + (f * a * a) - (a + b);
            Console.WriteLine("\n(a + b - (f / a)) + (f * a * a) - (a + b) = {0}", otvet);
             

            Console.ReadLine();
        }
    }
}
