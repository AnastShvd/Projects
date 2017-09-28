using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Class
{
    class Student
    {
        public string Name; 
        public string SurName;  // Создаём поля (переменные)
        public int Salary;
        public int Mark1, Mark2, Mark3; 
        //
        public int NumerateSalary(int Salary) // метод который возвращает значение стипендии за год (int Salary) - это вход метода, там у нас стипендия за месяцs
        {
            int result; 
            result = Salary * 9; 
            return result; 
        }
        //
        public void AverageMark(int Mark1, int Mark2, int Mark3) //метод который ничего не возвращает, считает среднее арифметическое 3-х оценок на входе 3 оценки (int Mark1, int Mark2, int Mark3)
        {
            int result;
            result = (Mark1 + Mark2 + Mark3) / 3;
            Console.WriteLine("Average mark:"+result);
        }
        //
        public static void ShowInformation(string name,string surname,int salary,int mark1,int mark2,int mark3) //статический метод, который показывает информацию от студенте на входе вся информация от студенте
        {
            Console.WriteLine("Name: {0}  SurName: {1}  Salary: {2}  Mark1: {3}  Mark2: {4}  Mark2: {5}", name,surname,salary,mark1,mark2,mark3);
        }



    }
}
