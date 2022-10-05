using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int score;
        static int health; // must be decalred outside so methods can see it
        static void Main(string[] args)
        {
            Console.WriteLine("Methods");
            Console.WriteLine();

            score = 0; //initilizations
            health = 100;

            ShowHUD(); //showing HUD using method
            score = score + 100;
            health = health - 10;
            // display HUD
            // Console.WriteLine("Score: " + score);
            //  Console.WriteLine("Health: " + health);
            // Console.WriteLine();

            ShowHUD(); //showing HUD w new results but using method
            score = score + 100;             // earn points
            health = health - 10;             // get hurt

            // display HUD showing new results 
            // Console.WriteLine("Score: " + score);
            // Console.WriteLine("Health: " + health);
            // Console.WriteLine();

            FullRestore();

            Heal(10000000);
            Heal(5);
            ShowHUD();

            Console.ReadKey(true);
        }

        static void ShowHUD() //declaration
        {
            // displays HUD
            Console.WriteLine("___________________________");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("___________________________");
            Console.WriteLine();
        }

        static void FullRestore() //method for healing to 100% 
        {
            health = 100;
        }

        static void Heal(int hp) //method for healing incrementally using int
        {
            health = health + hp;
            if (health > 100)
            {
                health = 100;
            }
        }
    }
}
