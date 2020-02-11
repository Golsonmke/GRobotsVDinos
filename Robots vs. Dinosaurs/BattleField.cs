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
          public Herd myherd = new Herd();
          public Fleet myfleet = new Fleet();
          public List<Herd> Dinosaurs;
          public List<Fleet> Robots;


        public BattleField()
        {
           
            
             
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
            myfleet.robots[0].Attack(myherd.dinosaurs[0]);
            myfleet.robots[1].Attack(myherd.dinosaurs[1]);
            myfleet.robots[2].Attack(myherd.dinosaurs[2]);
            myherd.dinosaurs[0].DinoAttack(myfleet.robots[2]);
            myherd.dinosaurs[1].DinoAttack(myfleet.robots[1]);
            myherd.dinosaurs[2].DinoAttack(myfleet.robots[0]);

            if(myfleet.robots.Count <= myherd.dinosaurs.Count)
            {
                Console.WriteLine("Dinosaurs Win");
                Console.ReadLine();
            }
            else if(myherd.dinosaurs.Count <= myfleet.robots.Count)
            {
                Console.WriteLine("Robots Win");

            }
                    








        }
        public void  RunGame()
        {
            StartPage();
            Setup();
            Battle();


        }
    }

    
    

    
}

