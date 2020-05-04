using System;
using System.Collections.Generic;
using System.Text;

namespace Kompletering
{
    class Slasher : Enemy
    {
        protected string[] nameBase = { "Mikalando Slasho", "Stabo Bado", "Deflekto Mucho" };
        public Slasher() 
        {
            sliceDamage = 3;
            bluntDamage = 1;
        }
        protected string RandString(string[] total) //Takes a random string from an array
        {
            int retVal; //retVal = return value

            retVal = rand.Next(0, total.Length);

            return total[retVal];
        }
    }
}
