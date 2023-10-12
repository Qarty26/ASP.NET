using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; } 
        public string StudyLevel { get; set; }  
        public List<Materie> Materii { get; set; }


        public Student()
        {
            Name = string.Empty;
            Surname = string.Empty; 
            Year = 0;
            StudyLevel = string.Empty;
            Materii = new List<Materie>();
        }

        public void Afisare()
        {
            Console.WriteLine(Name + " " + Surname + " Year:" + Year + " Studying at:" + StudyLevel);
            Console.WriteLine("Currently studying:");
            foreach(Materie m in Materii)
            {
                m.Afisare();
            }
        }

    }

   
}
