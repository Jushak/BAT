using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BAT_WPF.Models
{
    [XmlRootAttribute("BAT_God", Namespace = "BAT_Data")]
    [Serializable()]
    public class God : Actor
    {
        List<String> portfolio;
        List<String> titles;
        List<String> combatFeats;
        List<String> favoredSkills;
        UInt16 genderSplit;
        Boolean priests;
        Boolean priestesses;

        

        #region Constructors
        public God()
            : base("TestGod")
        {
            Portfolio = new List<String>();
            Titles = new List<String>();
            CombatFeats = new List<String>();
            FavoredSkills = new List<String>();
            GenderSplit = 50;
            Priests = true;
            Priestesses = true;
        }

        public God(string name) 
            : base(name)
        {
            Portfolio = new List<String>();
            Titles = new List<String>();
            CombatFeats = new List<String>();
            FavoredSkills = new List<String>();
            GenderSplit= 50;
            Priests = true;
            Priestesses = true;
        }

        #endregion

        #region Getters and setters

        public List<string> Portfolio
        {
            get
            {
                return portfolio;
            }

            set
            {
                portfolio = value;
            }
        }

        public List<string> Titles
        {
            get
            {
                return titles;
            }

            set
            {
                titles = value;
            }
        }

        public List<string> CombatFeats
        {
            get
            {
                return combatFeats;
            }

            set
            {
                combatFeats = value;
            }
        }

        public List<string> FavoredSkills
        {
            get
            {
                return favoredSkills;
            }

            set
            {
                favoredSkills = value;
            }
        }

        public ushort GenderSplit
        {
            get
            {
                return genderSplit;
            }

            set
            {
                genderSplit = value;
            }
        }

        public bool Priests
        {
            get
            {
                return priests;
            }

            set
            {
                priests = value;
            }
        }

        public bool Priestesses
        {
            get
            {
                return priestesses;
            }

            set
            {
                priestesses = value;
            }
        }

        #endregion

    }
}
