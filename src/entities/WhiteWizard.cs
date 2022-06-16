using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game_jpg.src.entities
{
    public class WhiteWizard : Wizard
    {
        public WhiteWizard(
          string name, int level, string heroType) : base(name, level, heroType)
        {
            
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}