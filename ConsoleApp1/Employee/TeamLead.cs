using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TeamLead
    {
        private double _salary;
        private int _teamcount;

        public TeamLead(double Salary, int Teamcount)
        {
            _salary = Salary;
            _teamcount = Teamcount;
        }

       public Dictionary<string,double> salaryDetails()
      
        {

            Dictionary<string, double> dic = new Dictionary<string, double>();
            dic.Add("salary", _salary);      
            return dic;
        }
        public Dictionary<string,int> teamCount()

        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("TeamCount", _teamcount);
            return dic;
        }



    }

   

}
