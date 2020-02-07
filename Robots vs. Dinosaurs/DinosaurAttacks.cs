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
            public int bite;
            public int clawSwipe;
            public int tailWhip;
            public int stomp;
             

            //constructor
            public DinoAttack(int bite, int clawSwipe, int tailWhip, int stomp)
            {
                this.bite = bite;
                this.clawSwipe = clawSwipe;
                this.tailWhip = tailWhip;
                this.stomp = stomp;
            }
            //member methods 
            public void Bite()
            {
                bite = 50;
            }
            public void ClawSwipe()
            {
                clawSwipe = 25;
            }
            public void TailWhip()
            {
                tailWhip = 50;
            }
            public void Stomp()
            {
                stomp = 100;
            }
        }
    }

}
