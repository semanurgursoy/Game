using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign : IEntityCampaign
    {
        public string Name { get; set; }
        public int percent { get; set; }
    }
}
