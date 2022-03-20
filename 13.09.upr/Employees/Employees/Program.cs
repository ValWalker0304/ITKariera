using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee e1 = new FullTimeEmployee("1234", "Petar", "Sofia", "developer", "IT");
            Console.WriteLine(e1.CalculateSalary(10));
            Console.WriteLine(e1.GetDepartment());
            e1.Show();

            Console.WriteLine();

            ContractEmployee e2 = new ContractEmployee("5678", "Ivan", "Plovdiv", "Task", "IT");
            Console.WriteLine(e2.CalculateSalary(10));
            Console.WriteLine(e2.GetDepartment());
            e2.Show();
        }
    }
}
