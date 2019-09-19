using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabEx13___RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Building> buildDict = ReadData("./data/realestate.txt");
            ProcessRequests(buildDict);
        }//main

        /// <summary>
        /// Creates a dictionary of Building's by reading lines from a text file.
        /// </summary>
        /// <param name="file">The directory of the text file to be used</param>
        /// <returns></returns>
        static Dictionary<string, Building> ReadData(string file)
        {
            Dictionary<string, Building> buildDict = new Dictionary<string, Building>();
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Building buildingEntry = BuildingFactory.createBuilding(line);

                    //If returned building was NOT null, buildType was valid, add to dictionary.
                    if (buildingEntry != null)
                    {
                        buildDict.Add(buildingEntry.RefID, buildingEntry);
                    }
                }
                reader.Close();
                return buildDict;
            }
        }//readdata

        static void ProcessRequests(Dictionary<string, Building> buildDict)
        {
            //Comments added, our submissions are to "The Judge" and cannot include prompts.
            Console.WriteLine("Enter a reference ID in the format AA0000");
            Console.WriteLine("Examples: OS5581, HR8428");
            Console.WriteLine("Type '#' to stop");

            string input = Console.ReadLine().ToUpper();
            while (input != "#")
            {
                if (buildDict.ContainsKey(input))
                { 
                    Console.WriteLine(buildDict[input]);
                }
                else
                {
                    Console.WriteLine("unknown building");
                }
                input = Console.ReadLine().ToUpper();
            }
        }
    }
}
