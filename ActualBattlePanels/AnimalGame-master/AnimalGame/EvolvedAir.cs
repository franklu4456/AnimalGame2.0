using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class EvolvedAir:EvolvedAnimal
    {
        /// <summary>
        /// Constructor for evolved air animals
        /// </summary>
        /// <param name="maxHealth"></param>
        /// <param name="attack"></param>
        /// <param name="defense"></param>
        /// <param name="speed"></param>
        /// <param name="species"></param>
        /// <param name="level"></param>
        /// <param name="attack1"></param>
        /// <param name="attack2"></param>
        /// <param name="attack3"></param>
        public EvolvedAir(int maxHealth, int attack, int defense, int speed, Type species, int level, Attack attack1, Attack attack2, Attack attack3)
            : base(maxHealth, attack, defense, speed, Type.Water, level, attack1, attack2, attack3)
        {

        }
        public override bool LearnSpecialMove()
        {
            DamageAttack gust = new DamageAttack(Type.Rock, AttackEffect.EnemyHealthDown, Level * 4, "Gust");
            for (int i = 0; i < 3; i++)
            {
                if (_attackArray[i] is DamageAttack)
                {
                    _attackArray[i] = gust;
                }
            }
            return true;
        }
    }
}
