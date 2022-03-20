using System;
using System.Collections.Generic;
using System.Text;

namespace _17_11_2021
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public double Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string firstName, string lastName, int age, double salary)
        {
            this.salary = salary;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva.";
        }
        public void IncreaseSalary(double bonus) {
            if (this.age > 30)
            {
                this.salary += this.salary * bonus / 100;
            }
            else {
                this.salary += this.salary * bonus / 200;
            }
        }
    }
}
