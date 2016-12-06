using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    /// <summary>
    /// A singleton-class that contains static game information.
    /// </summary>
    public sealed class GameData
    {
        private static GameData instance = null;
        private static readonly object padlock = new object();

        Dictionary<string, Faith> faiths;
        Dictionary<string, God> gods;
        List<string> playerFactionMaleNames;
        List<string> playerFactionFemaleNames;

        /// <summary>
        /// Default constructor for GameData.
        /// </summary>
        GameData()
        {
            faiths = new Dictionary<string, Faith>();
            gods = new Dictionary<string, God>();
            playerFactionMaleNames = ReadNamesFromFile("MaleNames.txt");
            playerFactionFemaleNames = ReadNamesFromFile("FemaleNames.txt");
        }

        public static GameData Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null )
                    {
                        instance = new GameData();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// A method for generating a name for an Actor hailing from the player's faction based on gender
        /// </summary>
        /// <param name="gender">Gender of the character to generate a name for.</param>
        /// <returns>A name for an Actor.</returns>
        public string GeneratePlayerFactionActorName( char gender )
        {
            Random random = new Random();
            if ( gender == 'm')
                return (playerFactionMaleNames[(random.Next(0, playerFactionMaleNames.Count))]);
            else
                return (playerFactionMaleNames[(random.Next(0, playerFactionFemaleNames.Count))]);
        }

        /// <summary>
        /// A method for reading a file from the game's Data-folder, consisting of a list of names. Assumes one name
        /// per row.
        /// </summary>
        /// <param name="input">File name of the file to be read. I.e. "names.txt".</param>
        /// <returns>A List containing names from the given file.</returns>
        private List<string> ReadNamesFromFile (string input)
        {
            List<string> names = new List<string>();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\");
            string line = "";
            try
            {
                using (StreamReader sr = new StreamReader(path+input))
                {
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();
                        line.Trim();
                        names.Add(line);
                    }
                }
                Console.WriteLine("Lines: " + names.Count);
                Console.WriteLine("File "+path+input+" read!");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file "+path+input+" could not be read.");
                Console.WriteLine("Error message: ");
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            return names;
        }
    }
}
    
