using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    public class BattleField
    {
        // member variable (Has A)
          public Herd  myherd;
          public Fleet myfleet;
          public List<Herd> Dinosaurs;
          public List<Fleet> Robots;


        public BattleField()
        {
           myherd = new Herd();
            myfleet = new Fleet();
            List<Herd> Dinosaurs = new List<Herd>();
            List<Fleet> Robots = new List<Fleet>();
             
        }




        //Member Methods What Can the player do
        public void StartPage()
        {
            Console.WriteLine("Long ago in a Galaxy far far far far away");
            Console.WriteLine("Worlds collide in a Battle for the ages!");
            Console.WriteLine("ROBOTS VS DINOSAURS!");
            Console.WriteLine("Press Enter to Start Game");
            Console.ReadLine();
            Console.Clear();

        }

        public void Setup()
        {
            bool isValid = false;
            int numberOfWrong = 0;
            do
            {
                Console.WriteLine("Choose you your team?");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Robots":
                    case "Robot":
                    case "robot":
                    case "robots":

                        Console.WriteLine("You have chosen Robots");
                        isValid = true;
                        break;
                    case "Dinosaurs":
                    case "Dinosaur":
                        Console.WriteLine("You have chosen Dinosaurs");
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Please choose Robots or Dinosaurs");
                        numberOfWrong++;
                        break;
                }
            } while (isValid == false && numberOfWrong < 5);
            Console.Clear();

        }

        public void Battle()
        {
           

            Console.WriteLine("Press Enter to start battle!");
            Console.ReadLine();

           
          //  for (int i = 0; i < i++) 
          //  {

           // }
                
            



           
            

            

        }
        public void  RunGame()
        {
            StartPage();
            Setup();
            Battle();


        }
    }

    
    

    
}

