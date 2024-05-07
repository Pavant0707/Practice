using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//1)Create a program to manage a list of students.Each student has
//*properties such as

//* Name, Age, and Grade.Implement functionalities to add new students, remove students,
//         * and find students belonging to a particular grade using LINQ.
namespace Students
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int grade { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { id = 1,name="Kaushk",grade=1},
                new Student() { id = 2,name="sai ",grade =2}
            };

            students.Add(new Student() { id = 3, name = "allu arjun", grade = 3 });
            return students;
        }
            static void Main(string[] args)
            {

                Console.WriteLine("Names of all the students");

             var a=(from emp in Student.GetAllStudents() select emp).ToList();
            foreach (Student student in a)
            {
                Console.WriteLine(student.name);
            }
            Console.WriteLine("students removed by id");
            var b = (from emp in Student.GetAllStudents() where emp.id == 1 select emp).ToList();


            foreach (Student student in b)
            {
                Console.WriteLine(student.name);
            }

            var c = (from emp in Student.GetAllStudents() where emp.grade == 2 select emp);
            foreach (Student student in c)
            {
                Console.WriteLine("student found  by their grade" + " " + student.name);
            }

            Console.WriteLine("Names of all the students");

            var a1 = (from emp in Student.GetAllStudents() select emp).ToList();
            foreach (Student student in a1)
            {
                Console.WriteLine(student.name);
            }

        }
        }
    }

