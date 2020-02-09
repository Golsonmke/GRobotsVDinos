using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class DinosaurAttacks
    {
        public class DinoAttack
        {
            //member variables
            public string bite;
            public string clawSwipe;
            public string tailWhip;
            public string stomp;

            

            //constructor
            public DinoAttack()
            {
                new List<string>().Add("Bite");
                new List<string>().Add("Claw Swipe");
                new List<string>().Add("Tail Whip");
                new List<string>().Add("Stomp");

                foreach (string dinoAttack in new List<string>())
                {
                    Console.WriteLine(dinoAttack);
                }
            }
        }

        //member methods 


    }

}
