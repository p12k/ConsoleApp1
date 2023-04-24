using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Car : Bike
    {
        private string _carName;
        private string _carModel;
        public  Car(string carName, string carModel, string bikeName , string bikeModel) : base ( bikeName ,bikeModel)
        {
            
            _carName = carName; 
            _carModel = carModel;
        }

        public  CarModel carDetails()
        {
            return new CarModel() { carmodel = _carModel, carname =_carName };
        }
      
    }
    public class CarModel
    {
        public string carname { get; set; }
        public string carmodel { get; set; }



    }
}


//BikeModel bikeModel = 
//    new BikeModel()
//{
//    bikemodel = _bikeModel,
//    bikename = _bikeName
//};
//return new BikeModel()
//{
//    bikemodel = _bikeModel,
//    bikename = _bikeName
//};