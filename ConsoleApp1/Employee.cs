using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Employee
    {

        private readonly int _id;
        private readonly string _name;
        private readonly string _salary;


        public Employee(int id, string name, string salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public EmployeeModel getEmployeeDetails()
        {
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.Id = _id;
            employeeModel.Name = _name;
           double c=  Convert.ToDouble(_salary);
            employeeModel.Salary= c;
            return employeeModel;

                
           

        }
    }


    public class EmployeeModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public  double Salary { get; set; }

    }
}
