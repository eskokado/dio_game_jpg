using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game_jpg.src.entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;            
        }
    }
}