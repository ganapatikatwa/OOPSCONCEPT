using System;
namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the choice\n" +
                    "1)Single Inheritance\n2)Multilevel Inheritance");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // Single Inheritance
                        Employee s = new Employee(2, 1500, "raj", 18);
                        s.Display();
                        break;
                    case 2:
                        // Multilevel Inheritance
                        Parent p = new Parent();
                        p.Home();
                        p.Bike();

                        Child c = new Child();
                        c.Home();
                        c.Bike();
                        c.Cycle();
                        break;
                }
            }

        }
    }
}