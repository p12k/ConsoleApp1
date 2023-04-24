using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static class StaticClass1
    {
     static StaticClass1()
        {
            Console.WriteLine("static constructor");

        }


        public static void Abc()
        {
            Console.WriteLine("method call");


        }


      public static  void abc1()
        {
            Console.WriteLine("method call 1");

        }
    }

    
}
