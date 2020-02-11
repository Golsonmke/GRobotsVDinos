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
        public string type;
        public int health;
        public int energyLevel;
        public int attackPower;
        public bool isDead;



        //constructor
        public Dinosaur(string name, string type, int health, int energyLevel, int attackPower)
        {
            this.name = "Name";
            this.type = "Name";
            this.health = 500;
            this.energyLevel = 500;
            this.attackPower = 100;
            this.isDead = false;

            
        }

        //member methods Can Do 
        public void ChooseAttack()
        {
            foreach (string dinoAttack in new List<string>())
            {
                Console.WriteLine(dinoAttack);
            }
        }
        public void DinosaurAttackPower()
        {
            attackPower = 75;
        }
        public void DinosaurHealth()
        {
            health = 500;
        }
        public void DinosaurEnergyLevel()
        {
            energyLevel = 500;
        }
        public void DinosaurIsDead()
        {
            isDead = false;
        }
        public void DinoAttack(Robot robot)
        {
            robot.health -= attackPower;
        }







    }

}
