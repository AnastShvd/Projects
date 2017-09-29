using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 400; //рассширим буфер консоли, чтоб консоль не кушала выводимую информацию
            //1
            Student st1 = new Student(); // создаём студента
            st1.Name = "Alexander"; 
            st1.SurName = "Kuzmenko";
            st1.Salary = 1000; // тут присваиваем ему значения
            st1.Mark1 = 5;
            st1.Mark2 = 4;
            st1.Mark3 = 3;

            Student.ShowInformation(st1.Name, st1.SurName, st1.Salary, st1.Mark1, st1.Mark2, st1.Mark3); // вызываем статический метод для вывода информации о студенте (обрати внимание как он вызывается)
            Console.WriteLine("Salary of year:"+st1.NumerateSalary(st1.Salary)); // вызываем и сразу отображаем метод по подсчёту стипендии
            st1.AverageMark(st1.Mark1, st1.Mark2, st1.Mark3); // метод среднего арифметического

            Console.ReadKey();

            


        }
    }
}
