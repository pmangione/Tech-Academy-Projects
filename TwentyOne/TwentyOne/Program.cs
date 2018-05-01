using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}.  Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello {0}, would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "ya" || answer == "yes" || answer == "yeah")
            {
                Player player = new Player(playerName,bank);

                player.Id = Guid.NewGuid();
                
                using (StreamWriter file = new StreamWriter(@"C:\Users\pmang\OneDrive\Documents\CodeCamp\TwentyOneFolderText\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.Read();
        }

       
    }
}
