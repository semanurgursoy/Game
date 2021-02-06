using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool IsItRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
//        BUNA GEREK VAR MIII ?