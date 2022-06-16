using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game_jpg.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public override string Attack() {
            return $"{this.Name} lançou magia"; 
        }

        public string Attack(int bonus) {
            if(bonus > 6) {
                return $"{this.Name} lançou magia super efetiva com bonus de {bonus}"; 
            } else {
                return $"{this.Name} lançou magia força fraca com bonus de {bonus}"; 

            }

        }
    }
}