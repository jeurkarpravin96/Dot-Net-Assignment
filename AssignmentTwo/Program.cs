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
            Employee e1 = new Manager(basic:10);
            Employee e2 = new GeneralManager("cdac", "tushar", 11, 50000, "General Manager");
            Employee e3 = new CEO("kishor", basic:60000);

            //Console.WriteLine(e1.EmpNo+"  "+ e1.calcNetSalary()+"  "+e1.DeptNo + "  "+e1.Name);
            //Console.WriteLine(e2.EmpNo+"  "+e2.calcNetSalary()+"  "+e2.DeptNo+"  "+e2.Name);
            //Console.WriteLine(e3.EmpNo+"  "+e3.calcNetSalary()+"  "+e3.DeptNo+"  "+e3.Name);

            e1.Display();
            Console.WriteLine();
            e2.Display();
            Console.WriteLine();
            e3.Display();

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
                    name = "nothing";
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
                    deptNo = 1;
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

        public virtual void Display()
        {
            Console.Write(" Emp No :: "+EmpNo+" , Name ::  " + Name + " , Net Basic  ::  " + calcNetSalary() +" , Dept No :: "+DeptNo);
        }
    }

    public interface IDbFunctions
    {
        void insert();
        void update();
        void delete();
        
    }

    public class Manager : Employee, IDbFunctions
    {
        private string designation;
        public string Designation
        {
            set
            {
                if (value != "null")
                    designation=value;
                else
                    designation = "Employee";
            }
            get
            {
                return designation;
            }
        }

        public override decimal Basic { 

            get => base.basic;

            set
            {
                if (value >= 5000 && value <= 70000)
                    base.basic = value;
                else
                    base.basic = 15000;
            }
        }

        public Manager(string name="null",short deptNo=0,decimal basic=0,string designation="null") : base(name, deptNo, basic)
        {
            Designation = designation;

        }
      public override decimal calcNetSalary()
        {
            return Basic*11;
        }

        public void insert()
        {
            Console.WriteLine("inserted");
        }

        public void update()
        {
            Console.WriteLine("updated");
        }

        public void delete()
        {
            Console.WriteLine("deleted");
        }
        public override void Display()
        {
            base.Display();
            Console.Write(" , Designation ::  " + Designation);
         
        }
    }

    public class GeneralManager : Manager, IDbFunctions
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

            set
            {
                if (value >= 15000 && value <= 15000)
                    base.basic = value;
                else
                    base.basic = 30000;
            }
        }

        public GeneralManager(string perks="null",string name="null",short deptNo=0,decimal basic=0,string designation="null") :base(name,deptNo,basic, designation)
        {
            Perks = perks;
        }

        public override decimal calcNetSalary()
        {
            return Basic*15;
        }

        public override void Display()
        {
            base.Display();
            Console.Write(" Perks :: "+ Perks);
           
        }
    }

    public class CEO : Employee, IDbFunctions
    {
        public override decimal Basic
        {

            get => base.basic;

            set
            {
                if (value >= 150000 && value <= 7000000)
                     base.basic = value;
                else
                    base.basic = 30000;
            }
        }

        public CEO(string name="null",short deptNo=0,decimal basic=0):base(name,deptNo,basic)
        {

        }
        public sealed override decimal calcNetSalary()
        {
            return Basic * 25;
        }

        public void insert()
        {
            Console.WriteLine("inserted");
        }

        public void update()
        {
            Console.WriteLine("updated");
        }

        public void delete()
        {
            Console.WriteLine("deleted");
        }
    }

}
