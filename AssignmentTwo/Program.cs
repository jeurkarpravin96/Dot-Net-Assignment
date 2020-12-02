using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager("pravin",10,15000,"manager");
            Employee e2 = new Manager();
            Employee e3 = new Manager();

            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e3.EmpNo);
            decimal d= e1.calcNetSalary();
            Console.WriteLine(d);

            Console.WriteLine();

            Console.WriteLine(e3.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e1.EmpNo);

            Console.ReadLine();
           
        }
    }

  public abstract  class Employee
    {
        private string name;
        public string Name
        {
            set
            {
                if (value != "null")
                    name = value;
                else
                    Console.WriteLine("invalid name");
            }
            get
            {
                return name;
            }
        }
        //read only
        protected static int employeeNo=0; 
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("invalid department number");
            }
            get
            {
                return deptNo;
            }
        }

        // abstract decimal basic;
        protected decimal basic;
        public abstract decimal Basic
        {
            set;

            get;

        }

      public  abstract decimal calcNetSalary();

      public Employee(string name="null",short deptNo=0,decimal basic=0)
        {
            employeeNo++;
            empNo = employeeNo;
            Name = name;
            DeptNo = deptNo;
            Basic = basic;
        }

    }

    public class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            set
            {
                if (value != "null")
                    designation=value;
            }
            get
            {
                return designation;
            }
        }

        public override decimal Basic { 

            get => base.basic;

            set => base.basic=value;
        }

        public Manager(string name="null",short deptNo=0,decimal basic=0,string designation="null") : base(name, deptNo, basic)
        {
            Designation = designation;

        }
      public override decimal calcNetSalary()
        {
            return Basic*100;
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;
        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }

        public override decimal Basic
        {

            get => base.basic;

            set => base.basic = value;
        }

        public GeneralManager(string perks="null",string name="null",short deptNo=0,decimal basic=0,string designation="null") :base(name,deptNo,basic, designation)
        {
            Perks = perks;
        }

        public override decimal calcNetSalary()
        {
            return Basic*100;
        }
    }

    public class CEO : Employee
    {
        public override decimal Basic
        {

            get => base.basic;

            set => base.basic = value;
        }

        public CEO(string name="null",short deptNo=0,decimal basic=0):base(name,deptNo,basic)
        {

        }
        public sealed override decimal calcNetSalary()
        {
            return Basic * 1000;
        }
    }

}
