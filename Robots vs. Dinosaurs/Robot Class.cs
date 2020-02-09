using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{


    class Robot
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
            
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;          
            this.isDead = false;


        }
        
        //member methods (Can Do)
        public void ChooseWeapon()
        {
            
            
          
            
        }
        public void ChooseWeaponAttack()
        {
            attackPower = 50;
        }
        public void TakeDamage()
        {
            
        }
        
    }



}
