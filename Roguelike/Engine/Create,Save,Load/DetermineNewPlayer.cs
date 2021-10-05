using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.Create_Save_Load
{
    public class DetermineNewPlayer
    {
        // TODO Make UI insensitive i.e. Get rid of Console.Writelines
        public static void NewPlayer()
        {
            string input;
            bool stop = false;

            // loop until 
            while (!stop)
            {
                Console.WriteLine("Are you a new Player?");
                Console.Write(">> ");
                input = Console.ReadLine();

                if (input.ToLower() == "no")
                {
                    bool stopName = false;
                    string name;

                    while (!stopName)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("What is your name? (Case Sensitive)");
                        Console.Write(">> ");
                        name = Console.ReadLine();

                        // todo change to read from database file
                        // name check to make sure name and password match
                        using (StreamReader reader = File.OpenText(@"../../../Engine/Create,Save,Load/Players.csv"))
                        {
                            reader.ReadLine();

                            while (!reader.EndOfStream)
                            {
                                string[] tokens = reader.ReadLine().Split(',');

                                if (tokens[0] == name)
                                {
                                    string password;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("What is your Password?");
                                    Console.Write(">> ");
                                    password = Console.ReadLine();
                                    
                                    if (tokens[1] == password)
                                    {
                                        Console.WriteLine(Load.LoadPlayer(tokens));
                                        stopName = true;
                                        stop = true;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect Password!");
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Name not found!");
                                    continue;
                                }
                            }
                        }
                        Core.StandardMessages.BreakApartDisplay();
                        Console.ResetColor();
                    }
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
