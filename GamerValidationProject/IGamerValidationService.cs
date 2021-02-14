using System;
using System.Collections.Generic;
using System.Text;

namespace GamerValidationProject
{
    interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
