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

        public static int Count { get; internal set; }







        //constructor
        public Dinosaur(string name,
                        string type,
                        int health,
                        int energyLevel,
                        int attackPower)
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
        public void AttackPower()
        {
            
          attackPower = 100;
            

        }
        public void DinosaurHealth()
        {
            
           health = 500;
            if(health < 0)
            {
                isDead = true;
            }

        }
        public void EnergyLevel()
        {
            energyLevel = 500;
        }
       








    }

}
