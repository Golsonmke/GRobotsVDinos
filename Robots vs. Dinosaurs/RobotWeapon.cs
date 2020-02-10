using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{

    public class Weapon 
    {
        public string lightSaber;
        public string lazerGun;
        public string flameThrower;
        

        //constructor
        public Weapon()
        {
            Weapon lightSaber = new Weapon();
            Weapon lazerGun = new Weapon();
            Weapon flameThrower = new Weapon();
            


           List<Weapon> weapons = new List<Weapon>();
            weapons.Add(lightSaber);
            weapons.Add(lazerGun);
            weapons.Add(flameThrower);
           
            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine(weapon);
            }
        }

    }
        //member methods
       
        

    

}
