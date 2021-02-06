using Game.Entities;
using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign,GameInfo game)
        {
            game.Price-= (campaign.percent * game.Price) / 100;
            Console.WriteLine(campaign.Name.ToUpper()+"!\nBu kampanya kaçmaz :)\n"+game.Name+" oyunu sadece "+game.Price+" $.\n");
        }

        public void Delete(Campaign campaign,GameInfo game)
        {
            game.Price = game.OriginalPrice;
            Console.WriteLine(campaign.Name + " kampanyası sona erdi :(\n" + game.Name + " oyun fiyatı " + game.Price + " $.\n");
        }

        public void Update(Campaign campaign, int newPercent, GameInfo game)
        {
            game.Price -= (newPercent * game.Price) / 100;
            Console.WriteLine(campaign.Name.ToUpper() + "!\nBu kampanya kaçmaz :)\n" + game.Name + " oyunu güncellenen fiyatı sadece " + game.Price + " $.\n");
        }
    }
}
