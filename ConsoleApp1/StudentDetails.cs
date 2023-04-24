using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentDetails
    {
        public void GetStudentDetails()
        {
            // StudentModel studentModel=new StudentModel();
            // Student student = new Student(studentModel);
            //StudentModel student = new StudentModel();
            //student.name = "Pooja";
            //student.age = 25;
            //student.Address = "Bihar";
            //Console.WriteLine(student.name.ToLower());
            //Console.WriteLine(student.age.ToString());
            //Console.WriteLine(student.Address);

            //char[] b= studentModel.name.ToCharArray();

            //foreach(var c in b)
            //{
            //    Console.WriteLine(c);
            //    Console.WriteLine(studentModel.age);
            //    Console.WriteLine(studentModel.Address);
            //}
            //Console.WriteLine(b);
            //studentModel.age = 25;
            //studentModel.Address = "Bihar";
            //studentModel.name = "Pooja";
            Student student = new Student("Pooja", 25, "Bihar");
            StudentModel studentModel=  student.GetStudent();

            Console.WriteLine(studentModel.name);

            Console.WriteLine(studentModel.age);
            Console.WriteLine(studentModel.Address);





        }






    }
}
