using System;

namespace GamerValidationProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamer1 = new GamerManager(new GamerValidationManager());
            gamer1.Add(new Gamer { FirstName ="Erk" , LastName="Önder" , BirthYear =1995 , Id = 1 , NationalIdentity = 123456 });
            GamerManager gamer2 = new GamerManager(new GamerValidationManager());
            gamer2.Add(new Gamer { FirstName = "Ege", LastName = "Onat", BirthYear = 1995, Id = 2, NationalIdentity = 123457 });

        }
    }
}
