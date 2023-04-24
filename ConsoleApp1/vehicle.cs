using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class vehicle
    {
       public void Getcar()
        {
           car car = new car();
           car b= car.Specification();
          
            Console.WriteLine (b.carcolor);
            Console.WriteLine(b.cartype);
            Console.ReadLine();
        }

    }
}
