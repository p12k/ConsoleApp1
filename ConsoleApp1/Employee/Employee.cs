using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Employee : Manager
    {
        public Employee(double Salary, int Teamcount) : base(Salary, Teamcount)
        {
        }

        public EmployeeDetailsModel employeedetails()
        {
            EmployeeDetailsModel model = new EmployeeDetailsModel();
            model.Managersalary = salaryDetail().Salary;
            model.TeamLeadsalary = salaryDetails()["salary"];
            model.TeamCount = teamCount()["TeamCount"];
            return model;

        }
    }


    public class EmployeeDetailsModel
    {
        public  double Managersalary { get; set; }
        public  double TeamLeadsalary { get; set; }
        public  int TeamCount { get; set; }
    }
}
