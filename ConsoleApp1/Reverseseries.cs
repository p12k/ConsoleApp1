using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reverseseries
    {
        public void Reversecount()
        {
            int number = 123456789;
            int revereNumber = 0;
            int remainder = 0;
            Console.WriteLine("Number before reverse = " + number);

            //reverse number logic
            for (remainder = 0; number > 0; number = number / 10)
            {
                remainder = number % 10;

                revereNumber = revereNumber * 10 + remainder;
            }
            Console.WriteLine("Number after reverse  = " + revereNumber);

            //string s = "12345678";//87654321

            //Console.WriteLine($"series:{s}");
            // char[] a= s.ToCharArray().Reverse().ToArray();
            //Console.WriteLine($"reverse series:{a.ToString()}");




        }
    }

}
   
