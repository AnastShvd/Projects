using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ученики
{
    class Students
    {
        public string Name;
        public string Surname;
        public int Grants;
        public int Mark1;
        public int Mark2;
        public int Mark3;
        public int Number;

        public int GYear(int Grants)
        {
            int GY = Grants * 9;
            return GY;
        }

        public void MMM(int Mark1, int Mark2, int Mark3)
        {
            int M = ( Mark1 + Mark2 + Mark3) / 3;
            Console.WriteLine("\nСреднее арифметическое значение оценок студента номер {1}: {0}", M, Number);
        }

        public static void Info(string Name, string Surname, int Grants, int Mark1, int Mark2, int Mark3, int Number)//когда мы с тобой делали, то в скобочках вроде бы ничего не писали, а тут без этого выдает ошибку
        {
            Console.WriteLine($"Информация о студенте номер {Number}:\nИмя: {Name}\nФамилия: {Surname}\nСтипендия: {Grants}\nОценка1: {Mark1}\nОценка2: {Mark2}\nОценка3: {Mark3}\n\n");//про знак $ я в интернете увидела; это вместо С.WL("Число {0}",a)
        }
    }
}
