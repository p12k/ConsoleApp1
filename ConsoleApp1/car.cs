using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    

   public class car 
    {
    public string carcolor { get; set; }
    public string cartype { get; set; }

        public  car Specification()
        {
            car car1 = new car();
            car1.carcolor = "silver-grey";
            car1.cartype = "XUV";
            return car1;
           

        }


    }
}
