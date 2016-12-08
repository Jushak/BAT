using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BAT_WPF.Models
{
    /// <summary>
    /// A singleton-class that contains static game information.
    /// </summary>
    public sealed class GameData
    {
        private static GameData instance = null;
        private static readonly object padlock = new object();
        Random random;
        Dictionary<string, Faith> faiths;
        Dictionary<string, God> gods;
        Dictionary<string, string> councilorPics;
        List<string> playerFactionMaleNames;
        List<string> playerFactionFemaleNames;

        /// <summary>
        /// Default constructor for GameData.
        /// </summary>
        GameData()
        {
            random = new Random();
            faiths = new Dictionary<string, Faith>();
            gods = new Dictionary<string, God>();
            playerFactionMaleNames = ReadNamesFromFile("MaleNames.txt");
            playerFactionFemaleNames = ReadNamesFromFile("FemaleNames.txt");
            councilorPics = LoadCouncilorPics();
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

        #region Generators and providers

        /// <summary>
        /// A method for generating a name for an Actor hailing from the player's faction based on gender
        /// </summary>
        /// <param name="gender">Gender of the character to generate a name for.</param>
        /// <returns>A name for an Actor.</returns>
        public string GeneratePlayerFactionActorName( char gender )
        {
            if ( gender == 'm')
                return (playerFactionMaleNames[(random.Next(0, playerFactionMaleNames.Count))]);
            else
                return (playerFactionMaleNames[(random.Next(0, playerFactionFemaleNames.Count))]);
        }

        /// <summary>
        /// Provides randomly selected image source that a Leader uses. Age determines which one of a set of images is
        /// provided.
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public string GenerateLeaderPicture( char gender, int age )
        {
            if (gender == 'm')
                return councilorPics["Male1"];
            return councilorPics["Female1"];
        }

        /// <summary>
        /// Provides random number from centralized Random.
        /// </summary>
        /// <param name="min">Minimum value of the random spread</param>
        /// <param name="max">The cap below which the random number needs to be.</param>
        /// <returns>Random number with above parameters.</returns>
        public int GetRandom(int min, int max)
        {
            return (random.Next(min, max));
        }

        #endregion

        #region Data loading functions.

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

        /// <summary>
        /// Creates a Dictionary containing bitmaps for councilor images.
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> LoadCouncilorPics()
        {
            Dictionary<string, string> councilors = new Dictionary<string, string>();

            // TODO: More generic solution when I actually have more than two images to use.
            // TODO: Group images by name along the lines of: "MaleX_Young" / "MaleX_MiddleAged" / "MaleX_Old"
            // I.e. the game should use different image of the same Actor depending on how old the Actor is.
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\");
            councilors.Add("Male1", path+"CouncilorMale.png");
            councilors.Add("Female1", path+"CouncilorFemale.png");
            return councilors;
        }

        #endregion
    }
}
    
