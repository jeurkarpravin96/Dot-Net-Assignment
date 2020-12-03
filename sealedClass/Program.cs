using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class A
    {
        public virtual void Method()
        {
            Console.WriteLine("A Method");
        }
    }

  public  class B : A
    {
        public sealed override void Method()
        {
            Console.WriteLine("B Method");
        }
    }
  sealed public class C : B //you cant derived class from sealed class
    {
        //not allowed for override the method because method is sealed in the base class
        //public override void Method()   
        //{
        //    Console.WriteLine("B Method");
        //}
    }
    //public class E : C  //cant derived from sealed class
    //{

    //}
}
