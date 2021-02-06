using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class SalesManager : ISalesManager
    {
        public void SellTheGame(GameInfo game, Gamer gamer)
        {
            game.Users.Add(gamer);
            if (game.Price != game.OriginalPrice)
                Console.WriteLine(game.Name + " oyunu " + gamer.UserName + " kullanıcısına " + game.Price + "$'a kampanyalı olarak satıldı.");
            else
                Console.WriteLine(game.Name+" oyunu "+gamer.UserName+" kullanıcısına "+game.Price+"$'a satıldı.");
        }
        public void list(GameInfo game)
        {
            Console.WriteLine(game.Name+" oyununu satın alan kullanıcılar :");
            foreach (var user in game.Users)
            {
                Console.WriteLine("\t"+user.UserName);
            }
        }


    }
}
