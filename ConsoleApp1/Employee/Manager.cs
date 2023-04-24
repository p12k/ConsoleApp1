using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Manager :TeamLead
    {
        private double _salary;

        public  Manager(double Salary,int Teamcount) :base(Salary, Teamcount)
        {
            _salary = Salary;
            
        }

     public ManagerModel salaryDetail()
        {

            return  new ManagerModel() { Salary =_salary};
        }



    }

    public class ManagerModel {
    public double Salary { get; set; }
    
    
    }

}
