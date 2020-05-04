using System;
using System.Collections.Generic;
using System.Text;

namespace Kompletering
{

    class Boxer : Brawler
    {
        public Boxer()
        {
            name = RandString(nameBase);
            bluntDamage = rand.Next(2, 6) * bluntDamage;
            sliceDamage = rand.Next(2, 6) * sliceDamage;
            hp = 100;
            type = "Boxer";
        }
    }
}
