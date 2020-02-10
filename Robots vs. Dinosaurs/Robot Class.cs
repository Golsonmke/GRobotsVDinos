using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{


   public class Robot 
    {
        //member variables (has A)
        public string name;
        public int health;
        public int attackPower;
        public int powerLevel;
        public bool isDead;
        

        //constructor  (spawner)
        public Robot(string name, int health, int attackPower, int powerLevel, bool isDead)
        {
            
            this.name = "Name";
            this.health = 500;
            this.powerLevel = 500;
            this.attackPower = 100;          
            this.isDead = false;


        }


        //member methods (Can Do)
        public void ChooseWeapon()
        {

            foreach (string weapon in new List<string>())
            {
                Console.WriteLine(weapon);
            }

        }

        public void RobotHealth()
        {
            
            health = 500;
        }
        public void RobotAttackPower()
        {
            attackPower = 100;
        }
        public void PowerLevel()
        {
            powerLevel = 500;
        }
    }




}
