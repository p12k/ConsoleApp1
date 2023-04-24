using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demo
{
    public class StarPatternLoop
    {

        // public void starPatter()
        public void starPatter()
        {
            
            //< ---------simple star print----->
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //       // Console.Write(i%2==0 ?"*":"-");


            //    }
            //    Console.WriteLine("\n");
            //}


            //  < ----------------Reverse star----------->
            //            for (int i = 5; i >=1; i--)
            //            {
            //            for (int j = 1; j <=i; j++)
            //            {
            //              Console.Write("*");
            //                 }
            //               Console.WriteLine("\n");
            //    }
            //}
            //    *
            //   ***
            //  *****
            // *******
            //*********


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <=5 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int l = i - 1; l >= 1; l--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //var odd = 1;
            //for (var i = 5; i >= 1; i--)
            //{
            //    for (var j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (var k = 0; k < odd; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    odd += 2;
            //    Console.WriteLine();
            //}

            string a = "Pooja";
          
            for(var i = 0; i <a.Length; i++)
            {
                 
                Console.WriteLine(a[i]);
            }

        }
    }
}






