using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employer
    {
        public string Name;
        public int Age;
        public int Salary;

        public void NumerateSalary(int Age, int Salary)
        {
            int result;
            result = Age * Salary;
            Console.WriteLine(result);


        }

        public void ShowMessage()
        {
            Console.WriteLine("{0}  {1} ",Name,Age);
         
        }

    }
}
