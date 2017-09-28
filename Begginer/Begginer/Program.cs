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
            Console.WriteLine("Деление числа на разряды\n\nВведите 4хзначное число: \n");
            int r = Convert.ToInt32(Console.ReadLine());
            while ((r > 9999)|(r < 1000))
            {
                Console.WriteLine("Недопустимый формат. Введите чило ещё раз:");
                r = Convert.ToInt32(Console.ReadLine());
            }
            if ((r <= 9999) & (r >= 1000))
            {
                int e = r % 10;
                int d = r % 100; int d2 = d / 10;
                int s = r % 1000; int s2 = s / 100;
                int t = r / 1000;
                Console.WriteLine("\nВ этом числе {0} единиц, {1} десятков, {2} сотен и {3} тысяч", e, d2, s2, t);
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

            //четвертая задача_перевод текста в верхний/нижний ригистр
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Перевод текста в верхний/нижний регистр\n\nВведите текст:");
            string text = Console.ReadLine();

            Console.WriteLine("\nПеревод текста в верхний регистр: {0}", text.ToUpper());
            Console.WriteLine("\nПеревод текста в нижний регистр: {0}", text.ToLower());

            Console.ReadLine();
        }
    }
}
