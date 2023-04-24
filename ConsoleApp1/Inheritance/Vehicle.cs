using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public  class Vehicle: Car
    {
        public Vehicle(string carName, string carModel,string bikeName , string bikeModel) : base(carName, carModel, bikeName,bikeModel)
        {
        }
        public void showDetails()
        {
          //  var carModel = carDetails();
            var dic = bikeDetails();

           // Car car = new Car("XUV","XUV2010");
           // CarModel carModel = car.carDetails();
          // Console.WriteLine($"This is car Model:{carModel.carmodel},this is car name:{carModel.carname}");


           // Bike bike = new Bike("hero Honda", "1909");
           //// BikeModel bikeModel = bike.bikeDetails();
           //Dictionary<string, string>dic=bike.bikeDetails();
           //// Console.WriteLine($"This is bike model:{bikeModel.bikemodel},this is bike name:{ bikeModel.bikename}");
            Console.WriteLine($"This is bike model:{dic["bikeName"]},this is bike name:{dic["bikeModel"]}");
           


        }
    }
}
