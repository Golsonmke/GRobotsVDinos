using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    public class Herd 
    {
       public List<Dinosaur> dinosaurs = new List<Dinosaur>();
        
        
        
       
        public  Herd()
        {
            Dinosaur godZilla = new Dinosaur("GodZilla", "T-Rex", 600, 500, 75);
            Dinosaur mothra = new Dinosaur("Mothra", "Pterodactyl", 400,500,50);
            Dinosaur kingGhdorah = new Dinosaur("King Ghdoran", "Raptor", 500, 600, 50);

            
            dinosaurs.Add(godZilla);
            dinosaurs.Add(mothra);
            dinosaurs.Add(kingGhdorah);

            foreach(Dinosaur dinosaur in dinosaurs)
            {
                Console.WriteLine($"Dinosaur; {godZilla}");
            }

        } 
        
        

    }

}
