using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject1 = new Subject("Programming","Vivion Kinsella", 1);
            Subject subject2 = new Subject("Databases", "Padraig Harte", 1);
            Subject subject3 = new Subject("UX Design", "Adrian Durcan", 2);
            Subject subject4 = new Subject("OOP", "Keith McManus", 2);

            
           
            List<Subject> allSubjects = new List<Subject>();

            allSubjects.Add(subject1);
            allSubjects.Add(subject2);
            allSubjects.Add(subject3);
            allSubjects.Add(subject4);

            Student student1 = new Student("Joe Smith", "21/10/2000");
            Student student2 = new Student("Jane Brown", "21/10/2000");
            // Student student2 = new Student("Jane Brown", "21/10/2000", List < Subject > subject3, );

            List<Student> allStudents = new List<Student>();

            allStudents.Add(student1);
            allStudents.Add(student2);




            Display(allSubjects);
            Display2(allStudents);


        }
        private static void Display(List<Subject> subject)
        {
            Console.WriteLine($"{"Name"}\t{"Lecturer"}\t{"Year"}");
            foreach (Subject subjects in subject)
            {
                Console.WriteLine(subjects);
            }
        }
        private static void Display2(List<Student> student)
        {
          
            foreach (Student students in student)
            {
                Console.WriteLine(students);
            }
        }


    }
}
