using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultate UEO = new Facultate("UEO");
            UEO.Studenti = new Student[] {new Student("Bulugu", "Iulia", new DateTime(2002, 01, 01), "1"),
                              new Student("Harii", "Davinna", new DateTime(2002, 01, 02), "2"),
                              new Student("Amalia", "Gurau", new DateTime(2002, 01, 03), "3")};


            Console.WriteLine(UEO.Index("12"));
            Console.WriteLine("Scrie numarul matricol: ");
            string NrMat = Console.ReadLine();
            Console.WriteLine(UEO.Index(NrMat));


        }
    }
}
