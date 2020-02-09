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
        public string choosAttack;
        public bool isDead;
        
         





        //constructor
        public  Dinosaur(string name, int health, int energyLevel, int attackPower)
        {
            this.name = name;
            this.health = 500;
            this.energyLevel = 500;
            this.attackPower = 100;
            this.isDead = false;

            
            
        }

        //member methods Can Do 


        public void ChooseDinosaurAttack()
        {

            Console.WriteLine();
            Console.ReadLine();
        }










    }

}
