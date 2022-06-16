using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game_jpg.src.entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(
          string name, int level, string heroType) : base(name, level, heroType)
        {
            
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public override string Attack() {
            return $"{this.Name} lançou magia negra"; 
        }

        public string Attack(int bonus) {
            if(bonus > 6) {
                return $"{this.Name} lançou magia negra super efetiva com bonus de {bonus}"; 
            } else {
                return $"{this.Name} lançou magia negra força fraca com bonus de {bonus}"; 

            }

        }

    }
}