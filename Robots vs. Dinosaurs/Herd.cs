using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Herd
    {
        Dinosaur godzilla = new Dinosaur("Gozilla", 500, 500, 50, 100);
        Dinosaur mothra = new Dinosaur("Mothra", 500, 500, 50, 100);
        Dinosaur behemoth = new Dinosaur("Behemoth", 500, 500, 50, 100);
        Dinosaur avonlea = new Dinosaur("Avonlea", 500, 500, 50, 100);

        public void HerdAttackPower()
        {
            godzilla.attackPower = 50;
            mothra.attackPower = 20;
            behemoth.attackPower = 25;
            avonlea.attackPower = 50;
        }
        public void HerdHealth()
        {
            godzilla.health = 400;
            mothra.health = 500;
            behemoth.health = 500;
            avonlea.health = 400;
        }
        public void HerdEnergyLevel()
        {
            godzilla.energyLevel = 500;
            mothra.energyLevel = 500;
            behemoth.energyLevel = 500;
            avonlea.energyLevel = 500;
        }
        public void SpecialAttack()
        {
            godzilla.specialAttack = 100;
            mothra.specialAttack = 100;
            behemoth.specialAttack = 100;
            avonlea.specialAttack = 105;
        }
           

    }
}
