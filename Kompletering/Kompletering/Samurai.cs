using System;
using System.Collections.Generic;
using System.Text;

namespace Kompletering
{
    class Samurai : Slasher
    {
        public Samurai()
        {
            name = RandString(nameBase);
            sliceDamage = rand.Next(2, 6) * sliceDamage;
            bluntDamage = rand.Next(2, 6) * bluntDamage;
            hp = 100;
            type = "Samurai";
        }
    }
}
