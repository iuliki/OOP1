using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Student
    {
        public string LastName;
        public string FirstName;
        public DateTime DateOfBirth;
        public string NrMatricol;


        public Student(string LastName, string FirtsName, DateTime DateOfBirth, string NrMatricol)
        {
            this.LastName = LastName;
            this.FirstName = FirtsName;
            this.DateOfBirth = DateOfBirth;
            this.NrMatricol = NrMatricol;

        }
    }
}
