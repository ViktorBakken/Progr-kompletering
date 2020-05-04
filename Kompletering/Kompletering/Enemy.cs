using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Kompletering
{
    class Enemy
    {
        protected Random rand = new Random();
        protected float hp;
        protected string name;
        protected float sliceDamage;
        protected float bluntDamage;
        protected float blockChance = 60;
        private bool isDead;
        protected string type;


        public string Type
        {
            get
            {
                return type;
            }
        }
        public float Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;

                hp = MathF.Max(hp, 0);

                if (hp.Equals(0))
                {
                    isDead = true;
                }
            }
        }
        public bool IsDead
        {
            get
            {
                return isDead;
            }

            set
            {
                isDead = value;
            }
        }
        public float BlockChance
        {
            get
            {
                return blockChance;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public float DealDamage() //This method returns damage as a float
        {
            float attack = 0;
            int block = rand.Next(0, 100);

            if (block > blockChance)
            {
                Console.WriteLine("The attack was blocked\n");
            }
            else
            {
                int i = rand.Next(1, 2);
                if (i.Equals(1))
                {
                    attack = sliceDamage * rand.Next(1, 10);
                }
                else
                {
                    attack = bluntDamage * rand.Next(1, 10);
                }

                Console.WriteLine("Dealt " + attack + " damage!\n");
            }

            return attack;
        }

        public void TakeDamage(float damage) // This method takes a float and removes that from the hp.
        {
            Hp -= damage;
        }
    }
}
