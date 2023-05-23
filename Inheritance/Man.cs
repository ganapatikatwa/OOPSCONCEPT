using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    public class Man
    {
        public string Name;
        public int Age;
        public Man(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Employee:Man
    {
        public int empid;
        public int salary;

        public Employee(int empid, int salary, string name, int age): base (name,age)
        {
            this.empid = empid;
            this.salary = salary;

        }

        public void Display()
        {
            Console.WriteLine("Name--"+Name);
            Console.WriteLine("Age--" + Age);
            Console.WriteLine("ID--" + empid);
            Console.WriteLine("Salary--" + salary);

        }
    }
}
