using Game.Adapter;
using Game.Concrete;
using Game.Entities;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.NationalityId = "111";
            gamer.FirstName = "Semanur";
            gamer.LastName = "Gürsoy";
            gamer.DateOfBirthYear = 2000;
            gamer.UserName = "Sema";
            gamer.Email = "semanur@gmail.com";
            gamer.Password = "abc123";

            Gamer gamer2 = new Gamer();
            gamer2.NationalityId = "4356546";
            gamer2.FirstName = "Frodo";
            gamer2.LastName = "Baggins";
            gamer2.DateOfBirthYear = 2968;
            gamer2.UserName = "Bay Tepedibi";
            gamer2.Email = "frodo@gmail.com";
            gamer2.Password = "abcd1234";

            Gamer gamer3 = new Gamer();
            gamer3.NationalityId = "56456";
            gamer3.FirstName = "Legolas";
            gamer3.LastName = "SonOfThranduil";
            gamer3.DateOfBirthYear = 0;
            gamer3.UserName = "Greenleaf";
            gamer3.Email = "legolas@gmail.com";
            gamer3.Password = "asd123";

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            GamerManager gamerManager2 = new GamerManager(new NewEStateGamerCheckManager());

            gamerManager.Register(gamer);
            gamerManager.NormalRegister(gamer2);
            gamerManager.NormalRegister(gamer2);            
            gamerManager.UpdateUserName(gamer,"Nur");
            gamerManager.Delete(gamer);


            SalesManager salesManager = new SalesManager();

            GameInfo game = new GameInfo();
            game.Name = "Shadow of Mordor";
            game.Language = "Türkçe";
            game.Version = 5;
            game.OriginalPrice = 150;
            game.Price = 150;

            GameInfo game2 = new GameInfo();
            game2.Name = "Ring";
            game2.Language = "Türkçe";
            game2.Version = 2;
            game2.OriginalPrice = 135;
            game2.Price = 135;

            salesManager.SellTheGame(game, gamer);
            salesManager.SellTheGame(game, gamer2);
            salesManager.SellTheGame(game, gamer3);
            salesManager.list(game);

            salesManager.SellTheGame(game2, gamer2);
            salesManager.list(game2);

            Campaign campaign = new Campaign();
            campaign.Name = "Yılbaşı İndirimi";
            campaign.percent = 30;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign, game2);
            campaignManager.Update(campaign,30,game2);
            salesManager.SellTheGame(game2, gamer3);
            campaignManager.Delete(campaign, game2);

            salesManager.list(game2);

        }
    }       
}
