using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student [] students = new Student[3];

            Student student1 = new Student();
            student1.regNo = "11";
            student1.firstName = "Hafsa";
            student1.lastName = "Jitu";
            0
            Student student2 = new Student();
            student2.regNo = "12";
            student2.firstName = "amena";
            student2.lastName = "tasneem";

            Student student3 = new Student();
            student3.regNo = "13";
            student3.firstName = "shamima";
            student3.lastName = "akter";

            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            foreach(Student astudent in students)
            {
                Console.WriteLine(astudent.regNo + " " + astudent.GetFullName());

            }
            Console.ReadKey();


        }
    }
}
