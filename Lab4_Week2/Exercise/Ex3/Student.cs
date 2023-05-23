using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nFaculty number: {FacultyNumber}";
        }
    }
}
