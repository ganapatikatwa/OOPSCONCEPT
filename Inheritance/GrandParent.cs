using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GrandParent
    {
        public void Home()
        {
            Console.WriteLine("Home");
        }
    }
    public class Parent:GrandParent
    {
        public void Bike()
        {
            Console.WriteLine("Bike");
        }
    }
    public class Child : Parent
    {
        public void Cycle()
        {
            Console.WriteLine("Cycle");
        }
    }

}
