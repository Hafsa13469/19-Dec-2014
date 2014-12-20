using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsStackApp
{
    class Program
    {
        
       
       
        static void Main(string[] args)
        {
            Stack<Student> aStudent = new Stack<Student>();
            Student student1 = new Student();
            
            student1.firstName = "Hafsa";
            student1.lastName = "Jitu";

            Student student2 = new Student();
            student2.firstName = "amena";
            student2.lastName = "tasneem";

            aStudent.Push(student1);
            aStudent.Push(student2);

            foreach (Student bstudent in aStudent)
            {
                Console.WriteLine(bstudent.GetFullName());
            }
          
            Console.ReadKey();

        }
    }
}
