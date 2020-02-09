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

        


        //constructor
        public Dinosaur(string name, int health, int energyLevel , int attackPower)
        {
            name = "";
            health = 500;
            energyLevel = 500;
            attackPower = 100;

            Dinosaur godzilla = new Dinosaur("Godzilla", 500, 500, 100);
            Dinosaur mothra = new Dinosaur("Mothra", 500, 500, 100);
            Dinosaur kingGhdorah = new Dinosaur("King Ghidorah", 500, 500, 100);
            

        }

        //member methods Can Do 


        public void ChooseDinosaurAttack(List<string> dinoattacks)
        {

            Console.WriteLine(dinoattacks);
            Console.ReadLine();
        }   
       
        

        






   }   

}
