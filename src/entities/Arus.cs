using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game_jpg.src.entities
{
    public class Arus
    {
        public Arus()
        {            
        }
        public Arus(string name, int level, string heroType) 
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString() {
            return $"Name: {this.Name} - Level: {this.Level} - Type: {this.HeroType}";
        }
    }
}