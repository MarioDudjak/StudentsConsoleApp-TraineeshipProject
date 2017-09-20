using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Student:Person
    {
        public float Gpa { get; set; }
        public Student(int id, string firstName, string lastName, float gpa)
        {
            this.Id = id;
            this.Name= firstName;
            this.LastName = lastName;
            this.Gpa = gpa;
        }
    }
}
