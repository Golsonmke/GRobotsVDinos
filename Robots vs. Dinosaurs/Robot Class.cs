using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class RobotClass
    {
        public class Robot
        {
            //member variables
            public string name;
            public int health;
            public int attackPower;
            public int powerLevel;
            public int specialAttack;

            //constructor
            public Robot(string name, int health, int attackPower, int powerLevel, int specialAttack)
            {
                this.name = name;
                this.health = health;
                this.attackPower = attackPower;
                this.powerLevel = powerLevel;
                this.specialAttack = specialAttack;
            }

            //member methods
            public void Health()
            {

                health = 750;
            }
            public void AttackPower()
            {

                attackPower = 25;

            }
            public void PowerLevel()
            {
                powerLevel = 500;
            }
            public void SpecialAttack()
            {
                specialAttack = 75;
            }
        }


    }
}
