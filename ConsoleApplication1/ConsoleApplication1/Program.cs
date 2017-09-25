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
            Console.WriteLine("Enter two digits");
            
            Console.WriteLine("Enter 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a + b;//
            Console.WriteLine(result);
            Console.ReadKey();//here was a mistake (это пример изменения примера)
        }
    }
}
