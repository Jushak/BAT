using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public enum Seasons { Seeding, Growing, Harvesting, Decaying, Sleeping };

namespace BAT_WPF.Models
{
    /*
     * Model for game-specific info such as current year, season, player faction's name etc.
     * Includes both values shown in different sections of the UI as well as hidden info.
     */
    [XmlRootAttribute("BATSaveFile", Namespace = "BAT_Data")]
    [Serializable()]
    public class GameInfo : InfoBase
    {
        ushort year_;
        public Seasons season_;
        string factionName_;
        Boolean firstActionUsed;
        List<Leader> leaders_;
        List<Leader> councilors_;
        UInt16 population_;
        UInt16 goods_;
        UInt16 food_;
        UInt16 warriors_;
        UInt16 magic_;
        Int16 genderDominance_;
        UInt16 farmLand_;
        UInt16 wheatFields_;
        UInt16 barleyFields_;
        UInt16 ryeFields_;
        UInt16 forestLand_;
        UInt16 pastures_;
        UInt16 sheep_;
        UInt16 cows_;
        UInt16 pigs_;
        UInt16 horses_;

        #region Constructors
        public GameInfo()
        {
            year_ = 100;
            season_ = Seasons.Seeding;
            factionName_ = "TestFaction";
            firstActionUsed = false;
            leaders_ = new List<Leader>();
            councilors_ = new List<Leader>();
            population_ = 800;
            goods_ = 50;
            food_ = 800;
            warriors_ = 10;
            magic_ = 3;
            genderDominance_ = 50;
            farmLand_ = 250;
            forestLand_ = 200;
            wheatFields_ = 100;
            barleyFields_ = 100;
            ryeFields_ = 100;
            pastures_ = 150;
            sheep_ = 1000;
            cows_ = 800;
            pigs_ = 2000;
            horses_ = 50;
        }

        // Constructor for use with 
        public GameInfo(string filename)
        {
            // TODO: Read data from savefile.
        }

        // Debug constructor.
        public GameInfo(string name, ushort year)
        {
            year_ = year;
            season_ = Seasons.Seeding;
            factionName_ = name;
            leaders_ = new List<Leader>();
            councilors_ = new List<Leader>();
            population_ = 800;
            goods_ = 50;
            food_ = 800;
            warriors_ = 10;
            magic_ = 3;
            genderDominance_ = 50;
        }
        #endregion

        #region Getters and setters
        public ushort Year
        {
            get
            {
                return year_;
            }

            set
            {
                year_ = value;
            }
        }

        public string FactionName
        {
            get
            {
                return factionName_;
            }

            set
            {
                factionName_ = value;
            }
        }

        public List<Leader> Leaders
        {
            get
            {
                return leaders_;
            }

            set
            {
                leaders_ = value;
            }
        }

        public List<Leader> Councilors
        {
            get
            {
                return councilors_;
            }

            set
            {
                councilors_ = value;
            }
        }

        public ushort Population
        {
            get
            {
                return population_;
            }

            set
            {
                population_ = value;
            }
        }

        public ushort Goods
        {
            get
            {
                return goods_;
            }

            set
            {
                goods_ = value;
            }
        }

        public ushort Food
        {
            get
            {
                return food_;
            }

            set
            {
                food_ = value;
            }
        }

        public ushort Warriors
        {
            get
            {
                return warriors_;
            }

            set
            {
                warriors_ = value;
            }
        }

        public ushort Magic
        {
            get
            {
                return magic_;
            }

            set
            {
                magic_ = value;
            }
        }

        public short GenderDominance
        {
            get
            {
                return genderDominance_;
            }

            set
            {
                genderDominance_ = value;
            }
        }

        public Seasons Season
        {
            get
            {
                return season_;
            }

            set
            {
                season_ = value;
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

        public ushort FarmLand_
        {
            get
            {
                return FarmLand_1;
            }

            set
            {
                FarmLand_1 = value;
            }
        }

        public ushort ForestLand_
        {
            get
            {
                return ForestLand_1;
            }

            set
            {
                ForestLand_1 = value;
            }
        }

        public ushort Pastures_
        {
            get
            {
                return Pastures_1;
            }

            set
            {
                Pastures_1 = value;
            }
        }

        public ushort FarmLand_1
        {
            get
            {
                return farmLand_;
            }

            set
            {
                farmLand_ = value;
            }
        }

        public ushort WheatFields_
        {
            get
            {
                return wheatFields_;
            }

            set
            {
                wheatFields_ = value;
            }
        }

        public ushort BarleyFields_
        {
            get
            {
                return barleyFields_;
            }

            set
            {
                barleyFields_ = value;
            }
        }

        public ushort RyeFields_
        {
            get
            {
                return ryeFields_;
            }

            set
            {
                ryeFields_ = value;
            }
        }

        public ushort ForestLand_1
        {
            get
            {
                return forestLand_;
            }

            set
            {
                forestLand_ = value;
            }
        }

        public ushort Pastures_1
        {
            get
            {
                return pastures_;
            }

            set
            {
                pastures_ = value;
            }
        }

        public ushort Sheep_
        {
            get
            {
                return sheep_;
            }

            set
            {
                sheep_ = value;
            }
        }

        public ushort Cows_
        {
            get
            {
                return cows_;
            }

            set
            {
                cows_ = value;
            }
        }

        public ushort Pigs_
        {
            get
            {
                return pigs_;
            }

            set
            {
                pigs_ = value;
            }
        }

        public ushort Horses_
        {
            get
            {
                return horses_;
            }

            set
            {
                horses_ = value;
            }
        }

        #endregion

        #region Operations

        // A helper function that moves the game forward to the next season and where necessary next year.
        public void advanceSeason()
        {
            // Move to next season.
            switch(season_)
            {
                case Seasons.Seeding:
                    season_ = Seasons.Growing;
                    break;
                case Seasons.Growing:
                    season_ = Seasons.Harvesting;
                    break;
                case Seasons.Harvesting:
                    season_ = Seasons.Decaying;
                    break;
                case Seasons.Decaying:
                    season_ = Seasons.Sleeping;
                    break;
                case Seasons.Sleeping:
                    season_ = Seasons.Seeding;
                    // New year, advance year count and notify the UI to show it.
                    year_++;
                    this.NotifyPropertyChanged("year");
                    break;
            }
            // Notify UI of season change and reset action-tracking Boolean to false.
            this.NotifyPropertyChanged("season");
            firstActionUsed = false;
        }

        #endregion
    }
}
