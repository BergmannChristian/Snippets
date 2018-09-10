using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        //Player attributes
        static double PLAYER_HEALTH = 10.0;
        static string PLAYER_NAME = "";

        //Game state tracker
        static bool GAME_RUNNING = true;

        //Main game loop <START HERE>
        static void Main(string[] args)
        {

            while (GAME_RUNNING)
            {
                Game1_Debug();
            }
        }

        //To initialize player attributes and modify game values
        static public void Character_Creator()
        {

            Console.WriteLine("Enter your characters name:");
            PLAYER_NAME = Console.ReadLine().ToLower().Trim();

        }
       
        //Basic player attribute access     
        static public void Name_Display()
        {

            Console.WriteLine(PLAYER_NAME);

        }
        static public void Health_Display()
        {

            Console.WriteLine(PLAYER_HEALTH);

        }

        //GAME TESTS
        static public void Game1_Debug()
        {
            Character_Creator();

            Console.WriteLine("Welcome {0}! Your health is currently {1}", PLAYER_NAME, PLAYER_HEALTH);

            Console.WriteLine("END OF TEST");
            Console.ReadLine();
        }
    }
}
