using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Facultate
    {
        public string NumeFacultate;
        public Student[]Studenti;

        public Facultate(string NumeFacultate)
        {
            this.NumeFacultate = NumeFacultate;
        }

        public string Index(string NrMatricol)
        {
            for (int i = 0; i < Studenti.Length; i++)
            {
                if (string.Equals(NrMatricol, Studenti[i].NrMatricol))
                {
                    string s = Studenti[i].FirstName + " " + Studenti[i].LastName;
                    return s;
                }
            }
            return "Nu s-a gasit studentul!";
        }
    }
}
