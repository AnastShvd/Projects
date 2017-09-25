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
            while (n < 0)
            {
                Console.WriteLine("Недопустимый формат. Введите чиcло ещё раз:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            if (n > 0)
            {
                float m = n / 1000;
                Console.WriteLine("{0} метров это {1} километров", n, m);
            }

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Деление числа на разряды\n\nВведите 4хзначное число: \n");
            double r = Convert.ToDouble(Console.ReadLine());
            while ((r % 1 != 0)||(r > 9999)||(r < 1000))
            {
                Console.WriteLine("Недопустимый формат. Введите число ещё раз:");
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
                int t3 = t2 / 1000;

                Console.WriteLine("В этом числе {0} единиц, {1} десятков, {2} сотни и {3} тысяч", e, d3, s3, t3);
            }

            Console.ReadLine();
        }
    }
}
