﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GamerValidationProject
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_gamerValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Olundu");
            }
            else
            {
                Console.WriteLine("İşlem Başarısız Kayıt Olunamadı");
            }
            
        }



        public void Delete(Gamer gamer)
        {
            
        }



        public void Update(Gamer gamer)
        {
            
        }
    }
}
