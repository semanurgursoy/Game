using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class GameInfo : IEntityGame
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public int Version { get; set; }
        public int Price { get; set; }
        public int OriginalPrice { get; set; }
        public List<Gamer> Users = new List<Gamer>();
    }
}
