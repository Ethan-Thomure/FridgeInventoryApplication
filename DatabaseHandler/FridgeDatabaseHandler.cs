using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomureWeek8Task1.DatabaseHandler
{
    internal static class FridgeDatabaseHandler
    {
        private static string path = "../../../DatabaseHandler/FridgeDatabase.txt";
        public static void Save(List<FridgeType> fridgeContents)
        {
            using (TextWriter database = new StreamWriter(path, false))
            {
                foreach (FridgeType tuple in fridgeContents)
                {
                    database.Write(tuple.ToString() + "\n");
                }
            }
            return;
        }

        public static List<FridgeType> Load()
        {
            List<FridgeType> fridgeContents = new List<FridgeType>();
            string nextLine;

            using (StreamReader database = new StreamReader(path))
            {
                while ((nextLine = database.ReadLine()) != null)
                {
                    fridgeContents.Add(FridgeType.ToFridgeType(nextLine));
                }
            }
            return fridgeContents;
        }
    }
}
