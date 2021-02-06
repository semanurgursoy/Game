using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ISalesManager
    {
        void SellTheGame(GameInfo gameName,Gamer gamer);
        void list(GameInfo game);
    }
}
