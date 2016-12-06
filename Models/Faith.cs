using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BAT_WPF.Models
{
    /*
     * Model for a religious system. Holds random information used for generating text in events.
     */
    [XmlRootAttribute("BAT_Faith", Namespace = "BAT_Data")]
    [Serializable()]
    public class Faith
    {
        string name;
        string adjective;
        string plural;
        List<string> derogatoryAdjective;
        List<string> derogatoryPlural;
        List<string> derogatorySingle;
        List<string> pantheon;
        God mainGod;

        #region Constructors
        public Faith()
        {
            Name = "TestFaith";
            Adjective = "Tester";
            Plural = "Testers";
            DerogatoryAdjective = new List<String>();
            DerogatoryPlural = new List<String>();
            DerogatorySingle = new List<String>();
            MainGod = new God();
        }

        public Faith( string name )
        {
            name = name+"'s pantheon";
            Adjective = name + "n";
            Plural = name + "i";
            DerogatoryAdjective = new List<String>();
            DerogatoryPlural = new List<String>();
            DerogatorySingle = new List<String>();
            MainGod = new God(name);
        }

        #endregion

        #region Getters and setters

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Adjective
        {
            get
            {
                return adjective;
            }

            set
            {
                adjective = value;
            }
        }

        public string Plural
        {
            get
            {
                return plural;
            }

            set
            {
                plural = value;
            }
        }

        public List<string> DerogatoryAdjective
        {
            get
            {
                return derogatoryAdjective;
            }

            set
            {
                derogatoryAdjective = value;
            }
        }

        public List<string> DerogatoryPlural
        {
            get
            {
                return derogatoryPlural;
            }

            set
            {
                derogatoryPlural = value;
            }
        }

        public List<string> DerogatorySingle
        {
            get
            {
                return derogatorySingle;
            }

            set
            {
                derogatorySingle = value;
            }
        }

        public List<string> Pantheon
        {
            get
            {
                return pantheon;
            }

            set
            {
                pantheon = value;
            }
        }

        public God MainGod
        {
            get
            {
                return mainGod;
            }

            set
            {
                mainGod = value;
            }
        }

        #endregion

    }
}
