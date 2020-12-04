using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a No. of Employee :: ");
            int noOfEmp = Convert.ToInt32(Console.ReadLine());
            Employee[] Emp = new Employee[noOfEmp];

            for(int i = 0; i < Emp.Length; i++)
            {
                Console.WriteLine("Enter Employee "+(i+1)+" Details");
                Console.Write("Enter a Employee Number ");
                int empNo = Convert.ToInt32(Console.ReadLine());
             
                Console.Write("Enter a Employee Name ");
                String name = Console.ReadLine();
                Console.Write("Enter a Employee Salary ");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                Emp[i]= new Employee(name,sal,empNo);
            }
            Console.WriteLine();
            decimal max = Emp[0].Salary;
            int indexMax=0;
           for(int i = 0; i < Emp.Length; i++)
            {
                if (max < Emp[i].Salary)
                {
                    max = Emp[i].Salary;
                    indexMax = i;
                }          
            }
            Console.WriteLine(" Employee with highest Salary "+Emp[indexMax].EmpNo + " "+Emp[indexMax].EmpName+" " +Emp[indexMax].Salary);
            Console.WriteLine();
            Console.Write("Enter Employee Number to get details :: ");
            int empNo1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Emp.Length; i++)
            {
                if (empNo1==Emp[i].EmpNo)
                {
                    Console.WriteLine(Emp[i].EmpNo + " " + Emp[i].EmpName + " " + Emp[i].Salary);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Please Enter a Key to continue......");
            Console.ReadLine();
        }
    }
    class Employee
    {
        private String empName;
        public string EmpName
        {
            set
            {
                if (value == null)
                    empName = "annymous";
                else
                    empName = value;
            }
            get
            {
                return empName;
            }
        }
        private decimal salary;
        public decimal Salary
        {
            set
            {
                if (value >= 15000)
                    salary = value;
            }
            get
            {
                return salary;
            }
        }
        private int empNo;
        public int EmpNo
        {
            set
            {
                if (value > 0)
                    empNo = value;
                else
                    empNo = 1;
            }
            get
            {
                return empNo;
            }
        }
        public Employee()
        {
            this.empName = null;
            this.salary = 0;
        }
        public Employee(string empName, decimal salary,int empNo)
        {
            this.EmpName = empName;
            this.Salary = salary;
            this.EmpNo = empNo;
        }

        public void Display()
        {
            Console.WriteLine(EmpNo+" "+EmpName + " " + Salary);
        }

    }
}
