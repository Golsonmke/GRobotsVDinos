using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{ 
    public class Fleet
    {
       public List<Robot> robots = new List<Robot>();
        




        public Fleet()
        {
            Robot bobTheButcher = new Robot("Bob the Butcher", 500, 500, 100, false);
            Robot lazerLips = new Robot("LazerLips", 500, 500, 75, false);
            Robot johnny5 = new Robot("Johnny 5", 600, 450, 55, false);

            
            robots.Add(bobTheButcher);
            robots.Add(lazerLips);
            robots.Add(johnny5);

        }
        
        
       
           
            
            
        









    }

}
