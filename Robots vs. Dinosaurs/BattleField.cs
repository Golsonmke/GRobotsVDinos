using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class BattleField
    {
        public Herd herd;
        public Fleet fleet;
        public bool isDead;
        public string dinosaurs;
        public string robots;
        public string results;
        public BattleField()
        {
            isDead = false;

            
            
       
        }
        //Member Methods What Can the player do
        public void StartGame()
        {
            Console.WriteLine("Long ago in a Galaxy far far far far away");
            Console.WriteLine("Worlds collide in a Battle for the ages!");
            Console.WriteLine("ROBOTS VS DINOSAURS!");
            Console.WriteLine("Press Enter to Start Game");
            

        
        }

        public void ChooseDinosaursOrRobots()
        {


          

            
           

           





        }
        public void  AttackRobots(List<string> dinoattacks)
        {
            Console.WriteLine("Choose Attack" + dinoattacks);
            Console.ReadLine();

        }
        public void AttackPlayerOne()
        {

        }

        public void GameOver(string gameOver)
        {
         
        }

        


        
        


        

        

    }
        
    
        

    
}
