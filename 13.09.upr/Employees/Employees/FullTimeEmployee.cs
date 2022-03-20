using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition,
            string employeeDepartment)
            :            base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine("Employee position: " + this.employeePosition);
            Console.WriteLine("Employee department: " + this.employeeDepartment);
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours*10.80;
        }

        public override string GetDepartment()
        {
            return this.employeeDepartment;
        }
    }
}
