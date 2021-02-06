using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IGamerManager
    {
        void Register(Gamer gamer);
        void NormalRegister(Gamer gamer);
        void UpdateUserName(Gamer gamer,string newName);
        void UpdateEmail(Gamer gamer,string newEmail);
        void UpdatePassword(Gamer gamer,string newPassword);
        void Delete(Gamer gamer);

    }
}
