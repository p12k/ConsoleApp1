using ConsoleApp1.Demo;
//using ConsoleApp1.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        //static Program() {
        //    Console.WriteLine("static constructor");
        //}
      
        static void Main(string[] args)
        {
            // Calc calc = new Calc();
            // calc.Add(1,2,"9");
            // car car = new car();
            // car a= car.Specification();
            // Console.WriteLine(a.carcolor);
            // Console.WriteLine(a.cartype);
            // Console.ReadLine();
            //vehicle vehicle = new vehicle();
            //vehicle.Getcar();

            // StudentDetails studentDetails=new StudentDetails();
            // studentDetails.GetStudentDetails();
            //StaticClass1.Abc();
            //StaticClass1.Abc();
            //StaticClass1.abc1();
            //StaticClass1.abc1()

            //Reverseseries res = new Reverseseries();
            //res.Reversecount();
            //Console.WriteLine("Number after reverse  = " + res);

            // Vehicle vehicle=new Vehicle("XUV","2019","abc","5002");
            //vehicle.showDetails();
            //Employee emp = new Employee(2000.22,5);
            //EmployeeDetailsModel employeeDetails=  emp.employeedetails();
            //Console.WriteLine($"this is manager salary:{employeeDetails.Managersalary},this is teamlead salary:{employeeDetails.TeamLeadsalary},this is teamcount:{employeeDetails.TeamCount}");

            //<-----------DEMO____________>
            //Vehicle2 vehicle2 = new Vehicle2();
            //vehicle2.carBicMethod();
            StarPatternLoop starPatternLoop = new StarPatternLoop();
            starPatternLoop.starPatter();
            string str = "Poojakumari";
            char c = 'o';
            Console.WriteLine(count(str, c));
            Console.ReadLine();

        }

       public static int count(string s,char c)
        {
            int res = 0;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == c)
                res++;
            }
          return res;
        }     
    }
    }
  

    

