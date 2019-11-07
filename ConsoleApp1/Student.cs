using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
       
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public List<Subject> Subjects { get; }

        public Student(string name, string dateofbirth /*List<Subject> subjects*/)
        {
            Name = name;
            DateOfBirth = dateofbirth;
           // Subjects = subjectn;
            


        }
        public override string ToString()
        {
            //formatting string

            return $"{Name}\t{DateOfBirth}\t{Subjects}";
        }
    }
}
