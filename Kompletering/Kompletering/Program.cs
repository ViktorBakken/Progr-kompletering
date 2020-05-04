using System;
using System.Collections.Generic;
using System.Threading;

namespace Kompletering
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Enemy> enemieQue = new Queue<Enemy>(); //Create the Queue that will be filled with enemies
            Player player = new Player(); //Creates the player
            FillEnemieQue(enemieQue); //Fills the que with enemies
            Fight(player, enemieQue); //Starts the fight method
        }

        static void FillEnemieQue(Queue<Enemy> enemieQue) //Fills the Queue with two kinds of enemies
        {
            Random rand = new Random();
            int number = rand.Next(30, 50);
            Console.WriteLine("You will fight " + number + " fighters!\n");

            Enemy e = new Enemy();

            for (int i = 0; i < number; i++)
            {
                int x = rand.Next(1, 3);

                if (x.Equals(1))
                {
                    e = new Boxer();
                }
                else
                {
                    e = new Samurai();
                }

                enemieQue.Enqueue(e);
            }
        }

        static void Fight(Player player, Queue<Enemy> enemieQue) //The fighting method. 
        {
            Enemy enemy = enemieQue.Dequeue();
            Console.WriteLine(enemy.Name + " Walks in (" + enemy.Type + ").\n");
            Thread.Sleep(1000);

            while (!enemieQue.Count.Equals(0))
            {
                if (enemy.IsDead) //If the enemy is dead
                {
                    enemy = enemieQue.Dequeue();
                    Console.WriteLine(enemy.Name + "Walks in (" + enemy.Type + ").\n" + player.Name + " regained some hp.\n");
                    player.Hp += 40;                
                }

                Console.WriteLine("Player hp: " + player.Hp + "\nEnemy hp: " + enemy.Hp + "\n");
                Thread.Sleep(3000);
                 
                //The player atacks
                Console.WriteLine(player.Name + " attacks!");
                enemy.TakeDamage(player.DealDamage());
                Thread.Sleep(2000);

                if (!enemy.IsDead) //The enemy attacks
                {
                    Console.WriteLine(enemy.Name + " retaliated");
                    player.TakeDamage(enemy.DealDamage());
                    Thread.Sleep(2000);
                }
                if (player.Hp <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You died!");
                    break;
                }
            }
            if (player.Hp != 0)
            {
                Console.Clear();
                Console.WriteLine("You Won!");
            }
        }
    }
}
