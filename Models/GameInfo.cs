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
        int year_;
        public Seasons season_;
        string factionName_;
        Boolean firstActionUsed;
        List<Leader> leaders_;
        List<Leader> councilors_;
        int population_;
        int goods_;
        int food_;
        int warriors_;
        int magic_;
        int genderDominance_;
        int totalLand_;
        int wheatFields_;
        int barleyFields_;
        int ryeFields_;
        int forestLand_;
        int pastures_;
        int sheep_;
        int cows_;
        int pigs_;
        int horses_;

        // Temporary values for sliders until I get multi-value converters to work.
        int pastureMax_;
        int wheatMax_;
        int barleyMax_;
        int ryeMax_;

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
            totalLand_ = 650;
            forestLand_ = 200;
            wheatFields_ = 100;
            barleyFields_ = 100;
            ryeFields_ = 100;
            pastures_ = 150;
            sheep_ = 1000;
            cows_ = 800;
            pigs_ = 2000;
            horses_ = 50;

            pastureMax_ = 0;
            wheatMax_ = 0;
            barleyMax_ = 0;
            ryeMax_ = 0;
        }

        // Constructor for use with 
        public GameInfo(string filename)
        {
            // TODO: Read data from savefile.
        }

        // Debug constructor.
        public GameInfo(string name, int year)
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
            totalLand_ = 650;
            forestLand_ = 200;
            wheatFields_ = 100;
            barleyFields_ = 100;
            ryeFields_ = 100;
            pastures_ = 150;
            sheep_ = 1000;
            cows_ = 800;
            pigs_ = 2000;
            horses_ = 50;

            pastureMax_ = 0;
            wheatMax_ = 0;
            barleyMax_ = 0;
            ryeMax_ = 0;
        }
        #endregion

        #region Getters and setters
        public int Year
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

        public int Population
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

        public int Goods
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

        public int Food
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

        public int Warriors
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

        public int Magic
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

        public int GenderDominance
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

        public int TotalLand
        {
            get
            {
                return totalLand_;
            }

            set
            {
                totalLand_ = value;
            }
        }

        public int WheatFields
        {
            get
            {
                return wheatFields_;
            }

            set
            {
                wheatFields_ = value;
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
                return barleyFields_;
            }

            set
            {
                barleyFields_ = value;
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
                return ryeFields_;
            }

            set
            {
                ryeFields_ = value;
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
                return forestLand_;
            }

            set
            {
                forestLand_ = value;
            }
        }

        public int Pastures
        {
            get
            {
                calculatePastures();
                return pastures_;
            }

            set
            {
                pastures_ = value;
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
                return sheep_;
            }

            set
            {
                sheep_ = value;
            }
        }

        public int Cows
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

        public int Pigs
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

        public int Horses
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

        public int PastureMax
        {
            get
            {
                calculatePastureMax();
                return pastureMax_;
            }

            set
            {
                pastureMax_ = value;
            }
        }

        public int WheatMax
        {
            get
            {
                calculateWheatMax();
                return wheatMax_;
            }

            set
            {
                wheatMax_ = value;
            }
        }

        public int BarleyMax
        {
            get
            {
                calculateBarleyMax();
                return barleyMax_;
            }

            set
            {
                barleyMax_ = value;
            }
        }

        public int RyeMax
        {
            get
            {
                calculateRyeMax();
                return ryeMax_;
            }

            set
            {
                ryeMax_ = value;
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

        public void calculateForests()
        {
            forestLand_ = totalLand_ - pastures_ - wheatFields_ - barleyFields_ - ryeFields_;
        }

        public void calculatePastures()
        {
            pastures_ = totalLand_ - forestLand_ - wheatFields_ - barleyFields_ - ryeFields_;
        }


        public void calculatePastureMax()
        {
            pastureMax_ = pastures_+forestLand_;
        }

        public void calculateWheatMax()
        {
            wheatMax_ = pastures_ + wheatFields_;
        }

        public void calculateBarleyMax()
        {
            barleyMax_ = pastures_ + barleyFields_;
        }

        public void calculateRyeMax()
        {
            ryeMax_ = pastures_ + ryeFields_;
        }
        #endregion
    }
}
