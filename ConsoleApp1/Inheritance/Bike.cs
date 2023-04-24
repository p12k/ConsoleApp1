using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Bike
    {
        private string _bikeName;
        private string _bikeModel;
        public Bike(string bikeName, string bikeModel)
        {
            _bikeName = bikeName;
            _bikeModel = bikeModel;
        }

        public Dictionary<string,string> bikeDetails()
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("bikeName", _bikeName);
            dic.Add("bikeModel", _bikeModel);
            return dic;
           //BikeModel bikeModel = new BikeModel();
           // bikeModel.bikemodel = _bikeModel;
           // bikeModel.bikename = _bikeName;
           // return bikeModel;

        }

    }
    public class BikeModel
    {
        public string bikename { get; set; }
        public string bikemodel { get; set; }
    }
}
