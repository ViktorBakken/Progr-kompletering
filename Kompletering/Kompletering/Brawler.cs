using System;
using System.Collections.Generic;
using System.Text;

namespace Kompletering
{
    class Brawler : Enemy
    {
        protected string[] nameBase = { "Mike Slapson", "Rando Dasko", "Master Shieter" };
        public Brawler()
        {
            bluntDamage = 3;
            sliceDamage = 1;
        }

        protected string RandString(string[] total) //Takes a random string from an array
        {
            int retVal; //retVal = return value

            retVal = rand.Next(0, total.Length);

            return total[retVal];
        }
    }
}
