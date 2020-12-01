using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigenment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);


            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);



            Console.ReadLine();
        }
    }
    class Employee
    {

        //properyies validation
        private string empName;
        public string EmpName
        {
            set
            {
                if(value!=null)
                    empName = value;
                else
                    Console.WriteLine("Name should name be blank");
            }
            get
            {
                return empName;
            }
        }

        public static int no = 0;

        private  int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
                    

            }
        }
        private double empBasic;
        public double EmpBasic
        {
            set
            {
                if(value>5000 && value< 150000)
                    empBasic = value;
                else
                    Console.WriteLine("invalid Enter Basic between 5000 and 150000");
            }
            get
            {
                return empBasic;
            }
        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if(value>0)
                    deptNo = value;
                else
                    Console.WriteLine("invalid Dept No");
            }
            get
            {
                return deptNo;
            }
        }

       
        public Employee(String empName=null,double empBasic=0,short deptNo=0)
        {
            no++;
            empNo = no;
            DeptNo = deptNo;
            EmpName = empName;
            EmpBasic = empBasic;
        }


       public double GetNetSalary()
        {
            return empBasic*10;
        }


    }
}
