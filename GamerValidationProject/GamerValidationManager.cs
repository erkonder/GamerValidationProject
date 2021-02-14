using System;
using System.Collections.Generic;
using System.Text;

namespace GamerValidationProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.FirstName=="Erk" && gamer.LastName=="Önder" && gamer.BirthYear == 1995 && gamer.Id == 1 && gamer.NationalIdentity == 123456)
            {
                Console.WriteLine("Validation Tamamlandı");
                return true;
            }
            else
            {
                Console.WriteLine("Validation Tamamlanamadı");
                return false;
            }
        }
    }
}
