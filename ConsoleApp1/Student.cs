using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    public class Student
    {
        private readonly  string _name;
        private readonly  int _age;
        private readonly  string _address;
       
         public Student(string a,int b,string c)
       // public Student(StudentModel student )
        {
            _name = a;
            _age = b;       
            _address = c;


            //student.age = 25;
            //student.Address = "Bihar";         
            //student.name = "Pooja";

            
            //char[] b = student.name.ToCharArray();
            //Console.WriteLine(b[0]);


            // char [] details = student.ToCharArray(student);
            //Console.WriteLine(student);

        }
        public StudentModel GetStudent()
        {

            StudentModel model = new StudentModel();
            model.name = _name;
            model.age = _age;
            model.Address = _address;
            return model;   

                    
        }
    }



    public class StudentModel
    {
        public string name { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
    }
}
