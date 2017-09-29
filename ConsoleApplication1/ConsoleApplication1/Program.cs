using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer em1 = new Employer();
            Employer em2 = new Employer();

            em1.Name = "Alex";
            em1.Age = 20;
            em1.Salary = 10000;
            
            Console.WriteLine("{0} {1} {2} ",em1.Name,em1.Age,em1.Salary);
            em1.ShowMessage();

            

            em2.Name = "Nastya";
            em2.Age = 15;
            em2.Salary = 20000;

            em1.NumerateSalary(em2.Age, em2.Salary);
            em2.ShowMessage();

            Console.ReadKey();
        }
    }
}
