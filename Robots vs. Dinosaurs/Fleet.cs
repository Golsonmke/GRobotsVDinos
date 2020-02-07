using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class FleetClass
    {
        public class Fleet
        {
            //member variables
           public Robot butcherBob = new Robot("butcherBob", 750, 25, 500, 75);

            //constructor
            public Fleet(string butcherBob, string lazerLips, string johnny5)
            {
                this.butcherBob = butcherBob;
                this.lazerLips = lazerLips;
                this.johnny5 = johnny5;
            }
            //member methods
            public void ButcherBob()
            {
                
            }

            
            

        }
    }
}
