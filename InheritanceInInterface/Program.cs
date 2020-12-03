using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunction e = new Employee();

            IDisplayResult e2 = new Employee();
            //e2.Extra(); not accessible

            Employee e1 = new Employee();
            e1.Extra();//all method are accessible non virtual method

            Console.ReadLine();
        }
    }
    interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();
    }

    interface IDisplayResult : IDbFunction
    {
        void Show();
        void Display();
    }

    class Employee : IDisplayResult
    {
        public void Delete()
        {
            Console.WriteLine("delete");
        }

        public void Display()
        {
            Console.WriteLine("display");
        }

        public void Insert()
        {
            Console.WriteLine("insert");
        }

        public void Show()
        {
            Console.WriteLine("show");
        }

        public void Update()
        {
            Console.WriteLine("update");
        }

        public void Extra()
        {
            Console.WriteLine("exttra");
        }
    }
}
