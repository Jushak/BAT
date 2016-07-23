using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    /*
     * Model for a religious system. Holds random information used for generating text in events.
     */
    public class Faith
    {
        string name_;
        string adjective_;
        string plural_;
        List<String> derogatoryAdjective_;
        List<String> derogatoryPlural_;
        List<String> derogatorySingle_;
        List<God> pantheon_;
        God mainGod_;

        #region Constructors
        public Faith()
        {
            Name_ = "TestFaith";
            Adjective_ = "Tester";
            Plural_ = "Testers";
            DerogatoryAdjective_ = new List<String>();
            DerogatoryPlural_ = new List<String>();
            DerogatorySingle_ = new List<String>();
            MainGod_ = new God();
        }

        public Faith( string name )
        {
            Name_ = name+"'s pantheon";
            Adjective_ = name + "n";
            Plural_ = name + "i";
            DerogatoryAdjective_ = new List<String>();
            DerogatoryPlural_ = new List<String>();
            DerogatorySingle_ = new List<String>();
            MainGod_ = new God(name);
        }

        #endregion

        #region Getters and setters
        public string Name_
        {
            get
            {
                return name_;
            }

            set
            {
                name_ = value;
            }
        }

        public string Adjective_
        {
            get
            {
                return adjective_;
            }

            set
            {
                adjective_ = value;
            }
        }

        public string Plural_
        {
            get
            {
                return plural_;
            }

            set
            {
                plural_ = value;
            }
        }

        public List<string> DerogatoryAdjective_
        {
            get
            {
                return derogatoryAdjective_;
            }

            set
            {
                derogatoryAdjective_ = value;
            }
        }

        public List<string> DerogatoryPlural_
        {
            get
            {
                return derogatoryPlural_;
            }

            set
            {
                derogatoryPlural_ = value;
            }
        }

        public List<string> DerogatorySingle_
        {
            get
            {
                return derogatorySingle_;
            }

            set
            {
                derogatorySingle_ = value;
            }
        }

        internal List<God> Pantheon_
        {
            get
            {
                return pantheon_;
            }

            set
            {
                pantheon_ = value;
            }
        }

        internal God MainGod_
        {
            get
            {
                return mainGod_;
            }

            set
            {
                mainGod_ = value;
            }
        }
        #endregion

    }
}
