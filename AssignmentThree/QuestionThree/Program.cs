using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s=new Student[5];
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Student "+(i+1)+" details ");

                Console.Write("Enter student name :: ");
                string name = Console.ReadLine();
                Console.Write("Enter student Roll No :: ");
                int rollno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter student mark :: ");
                decimal mark = Convert.ToDecimal(Console.ReadLine());
                s[i] = new Student(name, rollno, mark);
            }
            Console.WriteLine();

            foreach (Student s1 in s )
            {
                Console.WriteLine(s1.RollNo+" "+s1.Name+" "+s1.Mark);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    public struct Student
    {
        private string name;
        public string Name { 
            set {
                if (value != null)
                    name = value;
                }
            get
               {
                return name;
               }
          }
        private int rollNo;
        public int RollNo
        {
            set
            {
                if (value > 0)
                    rollNo = value;
            }
            get
            {
                return rollNo;
            }
        }
        private decimal mark;
        public decimal Mark
        {
            set
            {
                mark = value;
            }
            get
            {
                return mark;
            }
        }
        public Student(string name=null,int rollNo=0,decimal mark=0)
        {
            this.name = "null";
            this.mark = 0;
            this.rollNo = 0;
            this.Name = name;
            this.Mark = mark;
            this.RollNo = rollNo;
        }
    }
}
