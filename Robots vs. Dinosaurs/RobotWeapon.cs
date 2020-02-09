using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{

    public class Weapon
    {
        //member variables
        public string lightSaber;
        public string lazerGun;
        public string flameThrower;
        public string nukeBomb;

        //constructor
        public Weapon(string lightSaber, string lazerGun, string flameThrower, string nukeBomb)
        {

            new List<string>().Add("Light Saber");
            new List<string>().Add("Lazer gun");
            new List<string>().Add("Flame Thrower");
            new List<string>().Add("Nuke Bomb");

            foreach (string weapon in new List<string>())
            {
                Console.WriteLine(weapon);
            }
        }

    }
        //member methods
       
        

    

}
