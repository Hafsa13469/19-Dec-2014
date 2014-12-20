using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student();
            student1.regNo = "11";
            student1.firstName = "Hafsa";
            student1.lastName = "Jitu";
            
            Student student2 = new Student();
            student2.regNo = "12";
            student2.firstName = "amena";
            student2.lastName = "tasneem";

            Student student3 = new Student();
            student3.regNo = "13";
            student3.firstName = "shamima";
            student3.lastName = "akter";

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

             foreach(Student astudent in students)
            {
                Console.WriteLine(astudent.GetFullName());

            }
            Console.ReadKey();
        }
    }
}
