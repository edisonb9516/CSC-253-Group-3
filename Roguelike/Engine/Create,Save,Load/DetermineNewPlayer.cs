using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Create_Save_Load
{
    public class DetermineNewPlayer
    {
        public static void NewPlayer()
        {
            string input;
            bool stop = false;

            // loop until 
            while (stop == false)
            {
                Console.WriteLine("Are you a new Player?");
                Console.Write(">> ");
                input = Console.ReadLine();

                if (input.ToLower() == "no")
                {
                    stop = false; // TODO change this later when loading and saving is added
                    Console.WriteLine("Not supported yet sorry!");
                }
                else if (input.ToLower() == "yes")
                {
                    stop = true;
                    CreatePlayer.CreateNewPlayer();
                }
                else
                {
                    Console.WriteLine("Not a valid answer.");
                }
            }
        }
    }
}
