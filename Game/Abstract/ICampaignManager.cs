using Game.Entities;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignManager
    {
        void Add(Campaign campaign,GameInfo game);
        void Update(Campaign campaign,int newPercent, GameInfo game);
        void Delete(Campaign campaign,GameInfo game);
    }  
}
