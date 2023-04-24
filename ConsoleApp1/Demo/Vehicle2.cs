using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demo
{
    public class Vehicle2
    {
      
        
    public void carBicMethod()
        {
          

            Bicycle bicycle = new Bicycle("abc","abc500");
            BicycleModel model = bicycle.bycMethod();
            Console.WriteLine($"This is bicycle Model:{model.BicycleName},this is bicycle name:{model.BicycleType}");

            //Console.WriteLine(model.BicycleName);
            //Console.WriteLine(model.BicycleType);
            Car car = new Car("XUV","car600");
            Dictionary<string, string> dic = car.carMethod();

            Console.WriteLine($"this si car name:{dic["CarName"]}, this is car model:{dic["Carmodel"]}");
            Console.ReadLine();
        }
    }
}
