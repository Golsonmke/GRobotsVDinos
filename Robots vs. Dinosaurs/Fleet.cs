using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
   
    
   public class Fleet
   {
       Robot bobtheButcher = new Robot("Bob the Butcher", 750, 25, 500, 75);
       Robot lazerLips = new Robot("Lazer Lips", 500, 25, 500, 75);
       Robot johnny5 = new Robot("Johnny 5", 500, 25, 500, 75);
       Robot exmachina = new Robot("Ex Machina", 500, 25, 50, 75);


        public void RobotAttackPower()
        {
            bobtheButcher.attackPower = 25;
            lazerLips.attackPower = 50;
            johnny5.attackPower = 50;
            exmachina.attackPower = 45;
        }
        public void RobotHealth()
        {
            bobtheButcher.health = 750;
            lazerLips.health = 500;
            johnny5.health = 500;
            exmachina.health = 450;
        }
        public void RobotPowerLevel()
        {
            bobtheButcher.powerLevel = 400;
            lazerLips.powerLevel = 500;
            johnny5.powerLevel = 500;
            exmachina.powerLevel = 550;
        }
        public void RobotSpecialAttack()
        {
            bobtheButcher.specialAttack = 100;
            lazerLips.specialAttack = 75;
            johnny5.specialAttack = 75;
            exmachina.specialAttack = 75;

        }
        

        






   }
    
}
