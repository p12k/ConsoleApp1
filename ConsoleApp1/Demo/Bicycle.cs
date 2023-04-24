using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demo
{
    public class Bicycle
    {


        private string _bycleName;
        public string _bycleType;
        public Bicycle(string BycleName,string BycleType)
        {

            _bycleName = BycleName;
            _bycleType = BycleType;

        }

        public BicycleModel bycMethod() {
            BicycleModel model = new BicycleModel();
            model.BicycleName = _bycleName;
            model.BicycleType = _bycleType; 
            return model;

       }

    }
    public class BicycleModel {
    public string BicycleName { get; set; }
    public string BicycleType { get; set; }

    
    
    }
   

}
