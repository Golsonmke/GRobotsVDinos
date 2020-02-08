using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
 
        public class Dinosaur
        {
            //member variables
            public string name;
            public int health;
            public int energyLevel;
            public int attackPower;
            public int specialAttack;

            //constructor
            public Dinosaur(string name, int health, int energyLevel, int attackPower, int specialAttack)
            {
               this.name = name;
               this.health = health;
               this.energyLevel = energyLevel;
               this.attackPower = attackPower;
               this.specialAttack = specialAttack; 
            }


            //member methods
            public void Health()
            {
                health = 500;
            }
            public void EnergyLevel()
            {
                energyLevel = 500;
            }
            public void AttackPower()
            {
                attackPower = 50;
            }
            public void SpecialAttack()
            {
                specialAttack = 100;
            }
        }
}
