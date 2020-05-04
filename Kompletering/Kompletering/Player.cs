using System;
using System.Collections.Generic;
using System.Text;

namespace Kompletering
{
    class Player : Enemy
    {
        public Player()
        {
            blockChance = 90;
            bluntDamage = rand.Next(2, 6) * 3.5f;
            sliceDamage = rand.Next(2, 6) * 3.5f;
            hp = 120;
            NamePlayer();
        }

        public void NamePlayer()//A method to name the player
        {
            Console.WriteLine("Name your character!");
            string newName = Console.ReadLine();

            name = newName;

            Console.Clear();
        }
    }
}

    


