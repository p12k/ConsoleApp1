using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Demo
{
     public class Car
    {
        private readonly string _name;
        private readonly string _type;
        public Car(string name, string type)
        {
            _name = name;   
            _type = type;
        }  

        public Dictionary<string, string> carMethod()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("CarName", _name);
            result.Add("Carmodel", _type);
            return result;

           
        }

    }
}
