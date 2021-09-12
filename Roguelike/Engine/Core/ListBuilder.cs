using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.Core
{
    public class ListBuilder
    {
        private static string[] GetNextLine(StreamReader reader)
        {
            return reader.ReadLine().Split(' ');
        }
        public static void Build()
        {
            // TODO build lists here reading from .txt files and building to object lists

            #region Build Rooms

            using (StreamReader reader = File.OpenText(@"../../../Enigine/Assets/Rooms.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(GetNextLine(reader)[1]);

                    string name = GetNextLine(reader)[1];

                    string description = GetNextLine(reader)[1];

                    int northExit = int.Parse(GetNextLine(reader)[1]);

                    int southExit = int.Parse(GetNextLine(reader)[1]);

                    int eastExit = int.Parse(GetNextLine(reader)[1]);

                    int westExit = int.Parse(GetNextLine(reader)[1]);

                    int monsterId = int.Parse(GetNextLine(reader)[1]);

                    int itemID = int.Parse(GetNextLine(reader)[1]);

                    Location.Room.rooms.Add(new Location.Room(id, name, description, northExit, southExit, eastExit, westExit, monsterId, itemID));
                }
            }
            #endregion
        }
    }
}
