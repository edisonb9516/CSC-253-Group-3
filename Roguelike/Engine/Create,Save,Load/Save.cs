using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.Create_Save_Load
{
    public static class Save
    {
        public static string SavePlayer()
        {
            try
            {
                // todo change to read from databse file and save to database file
                StreamReader reader = File.OpenText(@"../../../Engine/Create,Save,Load/Players.csv");
                reader.ReadLine();
                int index = 1;
                bool newSave = true;
                bool overwriteSave = false;
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    index++;

                    if (tokens[0].Equals(Core.Player.Player.players[0].Name))
                    {
                        overwriteSave = true;
                        newSave = false;
                    }
                }
                reader.Close();

                if (newSave)
                {
                    StreamWriter writer = File.AppendText(@"../../../Engine/Create,Save,Load/Players.csv");

                    writer.WriteLine($"{Core.Player.Player.players[0].Name},{Core.Player.Player.players[0].Password},{Core.Player.Player.players[0].Class},{Core.Player.Player.players[0].Race},{Core.Player.Player.players[0].Hp}" +
                            $",{Core.Player.Player.players[0].CurrentHP},{Core.Player.Player.CurrentRoom.Id},{Core.Player.Player.players[0].Evasion},{Core.Player.Player.players[0].Attack},{Core.Player.Player.players[0].Gold}");

                    writer.Close();
                }
                if (overwriteSave)
                {
                    LineChange($"{Core.Player.Player.players[0].Name},{Core.Player.Player.players[0].Password},{Core.Player.Player.players[0].Class},{Core.Player.Player.players[0].Race},{Core.Player.Player.players[0].Hp}" +
                                $",{Core.Player.Player.players[0].CurrentHP},{Core.Player.Player.CurrentRoom.Id},{Core.Player.Player.players[0].Evasion},{Core.Player.Player.players[0].Attack},{Core.Player.Player.players[0].Gold}"
                                ,@"../../../Engine/Create,Save,Load/Players.csv", index);
                }

                return "Saved!";
            }
            catch(Exception ex)
            {
                return "Something went wrong!  ---  " + ex.Message;
            }
        }

        private static void LineChange(string playerInfo, string fileName, int line)
        {
            string[] arrLines = File.ReadAllLines(fileName);
            arrLines[line - 1] = playerInfo;
            File.WriteAllLines(fileName, arrLines);
        }
    }
}
