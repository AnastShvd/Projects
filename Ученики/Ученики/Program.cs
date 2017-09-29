using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ученики
{
    class Program
    {
        static void Main(string[] args)
        {
            Students St1 = new Students();
            Students St2 = new Students();

            St1.Number = 1;
            St1.Name = "Alex";
            St1.Surname = "Kuzmenko";
            St1.Grants = 1100;
            St1.Mark1 = 90;
            St1.Mark2 = 94;
            St1.Mark3 = 96;

            St2.Number = 2;
            St2.Name = "Anastasia";
            St2.Surname = "Shved";
            St2.Grants = 1100;
            St2.Mark1 = 92;
            St2.Mark2 = 94;
            St2.Mark3 = 96;

            Students.Info(St1.Name, St1.Surname, St1.Grants, St1.Mark1, St1.Mark2, St1.Mark3, St1.Number);
            Students.Info(St2.Name, St2.Surname, St2.Grants, St2.Mark1, St2.Mark2, St2.Mark3, St2.Number);

            Console.WriteLine($"Стипендия за год студента номер {St1.Number}: {St1.GYear(St1.Grants)}");//если бы был не void, то я бы в методе прописала бы Console.WriteLine и там бы указала {number} как в методе "Info", а так пришлось писать номер каждому студенту "вручную" (там где St1.Number)

            St1.MMM(St1.Mark1, St1.Mark2, St1.Mark3);


            Console.WriteLine($"Стипендия за год студента номер {St2.Number}: {St2.GYear(St2.Grants)}");

            St2.MMM(St2.Mark1, St2.Mark2, St2.Mark3);

            Console.ReadKey();
        }
    }
}
