using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public enum Seasons { Seeding, Growing, Harvesting, Decaying, Sleeping };

namespace BAT_WPF.Models
{
    
    [XmlRootAttribute("BATSaveFile", Namespace = "BAT_Data")]
    [Serializable()]
    /// <summary>
    /// Model for game-specific info such as current year, season, player faction's name etc.
    /// Includes both values shown in different sections of the UI as well as hidden info.
    /// </summary>
    public class GameInfo : InfoBase
    {
        #region Variables
        int year;
        public Seasons season;
        string factionName;
        Boolean firstActionUsed;
        List<Leader> leaders;
        List<Leader> councilors;
        int population;
        int goods;
        int food;
        int magic;
        int genderDominance;
        
        // Agriculture: All the variables that have to do with Agriculture screen 
        int totalLand;
        int wheatFields;
        int barleyFields;
        int ryeFields;
        int forestLand;
        int pastures;
        int sheep;
        int cows;
        int pigs;
        int horses;

        // Maximum values for sliders in Agriculture-screen.
        int pastureMax;
        int wheatMax;
        int barleyMax;
        int ryeMax;
        
        // Diplomacy:

        // Trade:

        // Militia:
        int warriors;

        // Maximum values for sliders in agriculture-screen.
        int warriorsMax;
        int innerPatrol;
        int innerPatrolMax;
        int outerPatrol;
        int outerPatrolMax;
        bool ramparts;
        bool watchTower;
        bool wall;
        bool moat;

        // Overview:
        int children;
        int crafters;
        int hunters;
        int traders;
        int nobles;
        int farmers;

        // Faith:

        // Exploration:      

        #endregion

        #region Constructors

        /// <summary>
        /// Basic constructor for GameInfo.
        /// </summary>
        public GameInfo()
        {
            year = 100;
            season = Seasons.Seeding;
            factionName = "TestFaction";
            firstActionUsed = false;
            leaders = new List<Leader>();
            councilors = new List<Leader>();
            population = 800;
            goods = 50;
            food = 800;
            warriors = 10;
            magic = 3;
            genderDominance = 50;

            totalLand = 650;
            forestLand = 200;
            wheatFields = 100;
            barleyFields = 100;
            ryeFields = 100;
            pastures = 150;
            sheep = 1000;
            cows = 800;
            pigs = 2000;
            horses = 50;
            pastureMax = 0;
            wheatMax = 0;
            barleyMax = 0;
            ryeMax = 0;

            warriorsMax = 15;
            innerPatrol = 3;
            innerPatrolMax = 4;
            outerPatrol = 2;
            outerPatrolMax = 3;
            ramparts = false;
            watchTower = false;
            wall = false;
            moat = false;

            children = 300;
            crafters = 10;
            hunters = 20;
            traders = 10;
            nobles = 30;
            farmers = 400;

            for (int i = 0; i < 30; i++)
                leaders.Add(createRandomLeader());
            for (int i = 0; i < 7; i++)
                councilors.Add(leaders[i]);
        }

        // Constructor for use with 
        /// <summary>
        /// Constructor for setting up the save file from a file.
        /// </summary>
        /// <param name="filename"></param>
        public GameInfo(string filename)
        {
            // TODO: Read data from savefile.
        }
        
        /// <summary>
        /// Debug constructor that takes name and starting year as input.
        /// </summary>
        /// <param name="Name">Name of the test faction</param>
        /// <param name="Year">Starting year.</param>
        public GameInfo(string Name, int Year)
        {
            year = Year;
            season = Seasons.Seeding;
            factionName = Name;
            leaders = new List<Leader>();
            councilors = new List<Leader>();
            population = 800;
            goods = 50;
            food = 800;
            warriors = 10;
            magic = 3;
            genderDominance = 50;

            totalLand = 650;
            forestLand = 200;
            wheatFields = 100;
            barleyFields = 100;
            ryeFields = 100;
            pastures = 150;
            sheep = 1000;
            cows = 800;
            pigs = 2000;
            horses = 50;
            pastureMax = 0;
            wheatMax = 0;
            barleyMax = 0;
            ryeMax = 0;

            warriorsMax = 15;
            innerPatrol = 3;
            innerPatrolMax = 4;
            outerPatrol = 2;
            outerPatrolMax = 3;
            ramparts = false;
            watchTower = false;
            wall = false;
            moat = false;

            children = 300;
            crafters = 10;
            hunters = 20;
            traders = 10;
            nobles = 30;
            farmers = 400;
        }
        #endregion

        #region Getters and setters
        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string FactionName
        {
            get
            {
                return factionName;
            }

            set
            {
                factionName = value;
            }
        }

        public List<Leader> Leaders
        {
            get
            {
                return leaders;
            }

            set
            {
                leaders = value;
            }
        }

        public List<Leader> Councilors
        {
            get
            {
                return councilors;
            }

            set
            {
                councilors = value;
            }
        }

        public int Population
        {
            get
            {
                return population;
            }

            set
            {
                population = value;
            }
        }

        public int Goods
        {
            get
            {
                return goods;
            }

            set
            {
                goods = value;
            }
        }

        public int Food
        {
            get
            {
                return food;
            }

            set
            {
                food = value;
            }
        }

        public int Warriors
        {
            get
            {
                return warriors;
            }

            set
            {
                warriors = value;
                NotifyPropertyChanged("Warriors");
                NotifyPropertyChanged("OuterPatrolMax");
                NotifyPropertyChanged("InnerPatrolMax");
            }
        }

        public int Magic
        {
            get
            {
                return magic;
            }

            set
            {
                magic = value;
            }
        }

        public int GenderDominance
        {
            get
            {
                return genderDominance;
            }

            set
            {
                genderDominance = value;
            }
        }

        public Seasons Season
        {
            get
            {
                return season;
            }

            set
            {
                season = value;
            }
        }

        public bool FirstActionUsed
        {
            get
            {
                return firstActionUsed;
            }

            set
            {
                firstActionUsed = value;
            }
        }

        public int TotalLand
        {
            get
            {
                return totalLand;
            }

            set
            {
                totalLand = value;
            }
        }

        public int WheatFields
        {
            get
            {
                return wheatFields;
            }

            set
            {
                wheatFields = value;
                NotifyPropertyChanged("WheatFields");
                NotifyPropertyChanged("Pastures");
                NotifyPropertyChanged("PastureMax");
                NotifyPropertyChanged("BarleyMax");
                NotifyPropertyChanged("RyeMax");
            }
        }

        public int BarleyFields
        {
            get
            {
                return barleyFields;
            }

            set
            {
                barleyFields = value;
                NotifyPropertyChanged("BarleyFields");
                NotifyPropertyChanged("Pastures");
                NotifyPropertyChanged("PastureMax");
                NotifyPropertyChanged("WheatMax");
                NotifyPropertyChanged("RyeMax");
            }
        }

        public int RyeFields
        {
            get
            {
                return ryeFields;
            }

            set
            {
                ryeFields = value;
                NotifyPropertyChanged("RyeFields");
                NotifyPropertyChanged("Pastures");
                NotifyPropertyChanged("PastureMax");
                NotifyPropertyChanged("WheatMax");
                NotifyPropertyChanged("BarleyMax");
            }
        }

        public int ForestLand
        {
            get
            {
                calculateForests();
                return forestLand;
            }

            set
            {
                forestLand = value;
            }
        }

        public int Pastures
        {
            get
            {
                calculatePastures();
                return pastures;
            }

            set
            {
                pastures = value;
                NotifyPropertyChanged("ForestLand");
                NotifyPropertyChanged("Pastures");
                NotifyPropertyChanged("WheatMax");
                NotifyPropertyChanged("BarleyMax");
                NotifyPropertyChanged("RyeMax");
            }
        }

        public int Sheep
        {
            get
            {
                return sheep;
            }

            set
            {
                sheep = value;
            }
        }

        public int Cows
        {
            get
            {
                return cows;
            }

            set
            {
                cows = value;
            }
        }

        public int Pigs
        {
            get
            {
                return pigs;
            }

            set
            {
                pigs = value;
            }
        }

        public int Horses
        {
            get
            {
                return horses;
            }

            set
            {
                horses = value;
            }
        }

        public int PastureMax
        {
            get
            {
                calculatePastureMax();
                return pastureMax;
            }

            set
            {
                pastureMax = value;
            }
        }

        public int WheatMax
        {
            get
            {
                calculateWheatMax();
                return wheatMax;
            }

            set
            {
                wheatMax = value;
            }
        }

        public int BarleyMax
        {
            get
            {
                calculateBarleyMax();
                return barleyMax;
            }

            set
            {
                barleyMax = value;
            }
        }

        public int RyeMax
        {
            get
            {
                calculateRyeMax();
                return ryeMax;
            }

            set
            {
                ryeMax = value;
            }
        }

        public int WarriorsMax
        {
            get
            {
                calculateWarriorMax();
                return warriorsMax;
            }

            set
            {
                warriorsMax = value;
            }
        }

        public int InnerPatrol
        {
            get
            {
                return innerPatrol;
            }

            set
            {
                innerPatrol = value;
                NotifyPropertyChanged("OuterPatrolMax");
            }
        }

        public int OuterPatrol
        {
            get
            {
                return outerPatrol;
            }

            set
            {
                outerPatrol = value;
                NotifyPropertyChanged("InnerPatrolMax");
            }
        }

        public bool Ramparts
        {
            get
            {
                return ramparts;
            }

            set
            {
                ramparts = value;
            }
        }

        public bool WatchTower
        {
            get
            {
                return watchTower;
            }

            set
            {
                watchTower = value;
            }
        }

        public bool Wall
        {
            get
            {
                return wall;
            }

            set
            {
                wall = value;
            }
        }

        public bool Moat
        {
            get
            {
                return moat;
            }

            set
            {
                moat = value;
            }
        }

        public int InnerPatrolMax
        {
            get
            {
                calculateInnerPatrolMax();
                return innerPatrolMax;
            }

            set
            {
                innerPatrolMax = value;
            }
        }

        public int OuterPatrolMax
        {
            get
            {
                calculateOuterPatrolMax();
                return outerPatrolMax;
            }

            set
            {
                outerPatrolMax = value;
            }
        }

        public int Children
        {
            get
            {
                return children;
            }

            set
            {
                children = value;
            }
        }

        public int Crafters
        {
            get
            {
                return crafters;
            }

            set
            {
                crafters = value;
            }
        }

        public int Hunters
        {
            get
            {
                return hunters;
            }

            set
            {
                hunters = value;
            }
        }

        public int Traders
        {
            get
            {
                return traders;
            }

            set
            {
                traders = value;
            }
        }

        public int Nobles
        {
            get
            {
                return nobles;
            }

            set
            {
                nobles = value;
            }
        }

        public int Farmers
        {
            get
            {
                calculateFarmers();
                return farmers;
            }

            set
            {
                farmers = value;
            }
        }

        #endregion

        #region Operations
        
        /// <summary>
        /// A helper function that moves the game forward to the next season and where necessary next year.
        /// </summary>
        public void advanceSeason()
        {
            // Move to next season.
            switch(season)
            {
                case Seasons.Seeding:
                    season = Seasons.Growing;
                    break;
                case Seasons.Growing:
                    season = Seasons.Harvesting;
                    break;
                case Seasons.Harvesting:
                    season = Seasons.Decaying;
                    break;
                case Seasons.Decaying:
                    season = Seasons.Sleeping;
                    break;
                case Seasons.Sleeping:
                    season = Seasons.Seeding;
                    // New year, advance year count and notify the UI to show it.
                    year++;
                    this.NotifyPropertyChanged("year");
                    break;
            }
            // Notify UI of season change and reset action-tracking Boolean to false.
            this.NotifyPropertyChanged("season");
            firstActionUsed = false;
        }

        #endregion

        #region Creators

        /// <summary>
        /// Creator for completely random leader, using player faction's gender dominance to decide gender.
        /// </summary>
        /// <returns>A randomly generated Leader belonging to the player faction.</returns>
        private Leader createRandomLeader()
        {
            Random random = new Random();
            // Generate age via "dice rolls". Age = 10+6d10, for variation between 18 and 70, with average of 43.
            int age = 10 + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11);

            string faith = "testFaith";
            char gender = 'g';
            // TODO: Gods & decide Leader god(s) based on how much influence a given god has in the player's faction. 
            List<String> gods = new List<String>();
            gods.Add("testGod");             
            // Decide leader gender based on gender dominance
            if ( random.Next(1,101) > genderDominance)
                gender = 'm';
            else
                gender = 'f';

            string name = GameData.Instance.GeneratePlayerFactionActorName(gender);

            Skill leadership = SkillGenerator(age);
            Skill bargaining = SkillGenerator(age);
            Skill combat = SkillGenerator(age);
            Skill custom = SkillGenerator(age);
            Skill magic = SkillGenerator(age);
            Skill animals = SkillGenerator(age);
            Skill plant = SkillGenerator(age);
            Skill lore = SkillGenerator(age);

            Leader leader = new Leader();
            return leader;
        }
        
        /// <summary>
        /// Creator for a young leader, using player faction's gender dominance to decide gender. 
        /// </summary>
        /// <returns>A young (18-36) Leader of player any gender.</returns>
        private Leader createYoungLeader()
        {
            Leader leader = new Leader();
            return leader;
        }

        /// <summary>
        /// A function for randomizing a Skill based on character's age. older characters are more likely to have
        /// higher skills due to experience.
        /// </summary>
        /// <param name="age">Age of the Actor in question.</param>
        /// <returns>A randomly determined skill level, with higher age more likely to generate higher value.</returns>
        private Skill SkillGenerator( int age)
        {
            Random random = new Random();
            int roll = 0;
            // Base skill. From None(0) to Great(0)
            roll += random.Next(0, 5);
            // For every year above 18, the character has a chance to increase his current skill level, up to skill of
            // Superior.
            for ( int i = age; i > 18; i--)
            {
                if ( roll < 5 && random.Next(1, 101) > (90 + roll))
                    roll++;
            }
            Skill skill = Skill.none;
            return skill;
        }

        #endregion

        #region UICalculations

        // Most likely temporary calculations solely for UI sliders and calculations etc.

        private void calculateForests()
        {
            forestLand = totalLand - pastures - wheatFields - barleyFields - ryeFields;
        }

        private void calculatePastures()
        {
            pastures = totalLand - forestLand - wheatFields - barleyFields - ryeFields;
        }
        
        private void calculatePastureMax()
        {
            pastureMax = pastures + forestLand;
        }

        private void calculateWheatMax()
        {
            wheatMax = pastures + wheatFields;
        }

        private void calculateBarleyMax()
        {
            barleyMax = pastures + barleyFields;
        }

        private void calculateRyeMax()
        {
            ryeMax = pastures + ryeFields;
        }

        private void calculateInnerPatrolMax()
        {
            innerPatrolMax = warriors - outerPatrol;
        }

        private void calculateOuterPatrolMax()
        {
            outerPatrolMax = warriors - innerPatrol;
        }

        private void calculateWarriorMax()
        {
            // Placeholder formula. Maximum number of elite warriors is either current number or 1.25% of population, whichever is higher.
            warriorsMax = Math.Max(warriors,(int)(Math.Floor(population * 0.025)));
        }

        private void calculateFarmers()
        {
            farmers = population - children - warriors - crafters - traders - hunters - nobles;
        }

        #endregion
    }
}
