using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RetoClases01
{
    class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public double Grade { get; set; }
        public Teacher Teacher { get; set; }

        public Student() { 
        }

        public string PrintStudentInfo()
        {
            return $"Alumno: {Name} - {Grade} - Profesor: {Teacher.Name}";
        }
    }
   
}

