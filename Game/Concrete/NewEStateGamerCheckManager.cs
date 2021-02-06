using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class NewEStateGamerCheckManager : IGamerCheckService
    {
        public bool IsItRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
