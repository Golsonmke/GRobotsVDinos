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
            public int lightSaber;
            public int lazerGun;
            public int flameThrower;
            public int nukeBomb;
            
            //constructor
            public Weapon(int lightSaber, int lazerGun, int flameThrower, int nukeBomb)
            {
                this.lightSaber = lightSaber;
                this.lazerGun = lazerGun;
                this.flameThrower = flameThrower;
                this.nukeBomb = nukeBomb;
            }
            //member methods
            public void LightSaber()
            {
                lightSaber = 25;
            }
            public void LazerGun()
            {
                lazerGun = 25;
            }
            public void FlameThrower()
            {
                flameThrower = 50;
            }
            public void NukeBomb()
            {
                nukeBomb = 100;
            }
                
        }
    
}
