using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{

    #region AssignmentThreeOfTwo
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of batches in CDAC :: ");
            int batch = Convert.ToInt32(Console.ReadLine());
            

            CDAC1[][] cdacBatch = new CDAC1[batch][];
            
            for (int i = 0; i < cdacBatch.Length; i++)
            {
          
                Console.Write("Enter number of students in batch " + (i + 1)+" :: ");
                int size = Convert.ToInt32(Console.ReadLine());
                
                cdacBatch[i] = new CDAC1[size];
            }

            for (int i = 0; i < cdacBatch.Length; i++)
            {
                Console.WriteLine("Enter a batch " + (i + 1) + " students details ");
                for (int j = 0; j < cdacBatch[i].Length; j++)
                {
                    //Console.WriteLine("Enter a " + (j + 1) + " students details ");
                    //Console.Write("Enter " + (j + 1) + " Student's PRN Number ");
                    //double PRN = Convert.ToDouble(Console.ReadLine());
                    //Console.Write("Enter " + (j + 1) + " Student's Name ");
                    //string Name = Console.ReadLine();
                    Console.Write("Enter Student "+(j+1)+" Marks :: ");
                    int mark = Convert.ToInt32(Console.ReadLine());
                    cdacBatch[i][j] = new CDAC1 { mark = mark };
                  }
              }
            Console.WriteLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine();
            for (int i = 0; i < cdacBatch.Length; i++)
            {
                Console.WriteLine(" Batch " + (i + 1) + " students marks ");

                for (int j = 0; j < cdacBatch[i].Length; j++)
                {
                    
                    Console.WriteLine();
                    Console.WriteLine(" Student ["+(j+1)+"] Mark :: "+cdacBatch[i][j].mark );
                }
                Console.WriteLine();
                Console.WriteLine("=========================================================");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Please Enter a Key to continue......");
            Console.ReadLine();
        }
         
    }
   public   class CDAC1
    {
      public int mark { set; get; }

      }
    #endregion
}