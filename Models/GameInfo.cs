using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum Seasons { Seeding, Growing, Harvesting, Decaying, Sleeping };

namespace BAT_WPF.Models
{
    public class GameInfo : GameInfoBase
    {
        UInt16 year;
        public Seasons season;
        string factionName;
        List<Leader> leaders;
        List<Leader> councilors;
        UInt16 population;
        UInt16 goods;
        UInt16 food;
        UInt16 warriors;
        UInt16 magic;
        Int16 genderDominance;

        #region Constructors
        public GameInfo()
        {
            year = 100;
            Season = Seasons.Seeding;
            FactionName = "TestFaction";
            leaders = new List<Leader>();
            councilors = new List<Leader>();
            population = 800;
            goods = 50;
            food = 800;
            warriors = 10;
            magic = 3;
            genderDominance = 50;
        }

        // Constructor for use with 
        public GameInfo(string filename)
        {
            // TODO: Read data from savefile.
        }
        #endregion

        #region Getters and setters
        public ushort Year
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

        internal List<Leader> Leaders
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

        internal List<Leader> Councilors
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

        public ushort Population
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

        public ushort Goods
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

        public ushort Food
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

        public ushort Warriors
        {
            get
            {
                return warriors;
            }

            set
            {
                warriors = value;
            }
        }

        public ushort Magic
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

        public short GenderDominance
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
        #endregion

        #region Operations

        // Function that moves the game forward to next season.
        public void advanceSeason()
        {
            // TODO:
            // 1. Random event generation.
            // 2. Apply changes to population etc.
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
                    year++;
                    this.NotifyPropertyChanged("year");
                    break;
            }
            this.NotifyPropertyChanged("season");
            population += 50;
            this.NotifyPropertyChanged("population");

        }

        #endregion
    }
}
