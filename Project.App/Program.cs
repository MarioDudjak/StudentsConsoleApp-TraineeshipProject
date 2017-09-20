using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Code;

namespace Project.App
{
    class Program
    {
        static StudentContainer studentContainer = new StudentContainer();

        static void Main(string[] args)
        {
            string operation;

            do
            {
              Console.Write("Operation: ");
              operation = Console.ReadLine();
                if (Validation.validateOperationName(operation))
                {
                    if (operation.ToLower() == Operations.operationDisplay) display();
                    else if (operation.ToLower() == Operations.operationEnlist) enlist();
                }
            } while (operation.ToLower()!=Operations.operationDisplay);
        }
        public static void display()
        {
            int i = 0;
            List<Student> students = studentContainer.Fetch();
            if (!students.Any())
            {
                Console.WriteLine("There are no students in the list.");
            }
            else
            {
                Console.WriteLine("Students in a system: ");

            }
            foreach (Student s in students)
            {
                i++;
                Console.WriteLine("{0}. {1}, {2} - {3}", i, s.Name, s.LastName, s.Gpa);
            }
        }
            public static void enlist()
        {
            string firstName, lastName, sGpa;
            float fGpa;
            bool check = true;
            Console.WriteLine("Student");
            do
            {
                Console.Write("First Name: ");
                firstName = Console.ReadLine();
                check = Validation.validateName(firstName);
            } while (!check);

            do
            {
                Console.Write("\nLast Name: ");
                lastName = Console.ReadLine();
                check = Validation.validateName(lastName);
            } while (!check);

            do
            {
                Console.Write("\nGPA: ");
                sGpa = Console.ReadLine();
                check = Validation.validateGPA(sGpa);
            } while (!check);
            float.TryParse(sGpa, out fGpa);
            Student student = new Student(StudentIdGenerator.getInstance().generateID(), firstName, lastName, fGpa);
            studentContainer.Add(student);
        }
    }
}
