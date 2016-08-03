using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BAT_WPF.Models
{
    public enum Skill { none, poor, mediocre, good, great, superior, heroic };

    /* 
     * Model for leaders - a catch-all term for nobles and other upper-class personage that form
     * the leadership of the faction. Form the pool of characters eligible for faction's council.
     */
    [XmlRootAttribute("BAT_Leader", Namespace = "BAT_Data")]
    [Serializable()]
    public class Leader : Actor
    {
        // What faith the leader follows, if any.
        string myFaith;
        // The main god(s) the leader follows.
        List<String> myGods;
        // Skills possessed by the leader, with numerical value going from 0 (no skill) to 6 (heroic).
        Skill leadership;
        Skill bargaining;
        Skill combat;
        Skill custom;
        Skill magic;
        Skill animals;
        Skill plants;
        Skill lore;

        public Leader()
            : base("TestLeader")
        {
            myFaith = "";
            myGods = new List<string>();
            Skill leadership = Skill.mediocre;
            Skill bargaining = Skill.mediocre;
            Skill combat = Skill.mediocre;
            Skill custom = Skill.mediocre;
            Skill magic = Skill.mediocre;
            Skill animals = Skill.mediocre;
            Skill plants = Skill.mediocre;
            Skill lore = Skill.mediocre;
        }

        #region Getters and setters
        public string MyFaith
        {
            get
            {
                return myFaith;
            }

            set
            {
                myFaith = value;
            }
        }

        public List<string> MyGods
        {
            get
            {
                return myGods;
            }

            set
            {
                myGods = value;
            }
        }

        public Skill Leadership
        {
            get
            {
                return leadership;
            }

            set
            {
                leadership = value;
            }
        }

        public Skill Bargaining
        {
            get
            {
                return bargaining;
            }

            set
            {
                bargaining = value;
            }
        }

        public Skill Combat
        {
            get
            {
                return combat;
            }

            set
            {
                combat = value;
            }
        }

        public Skill Custom
        {
            get
            {
                return custom;
            }

            set
            {
                custom = value;
            }
        }

        public Skill Magic
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

        public Skill Animals
        {
            get
            {
                return animals;
            }

            set
            {
                animals = value;
            }
        }

        public Skill Plants
        {
            get
            {
                return plants;
            }

            set
            {
                plants = value;
            }
        }

        public Skill Lore
        {
            get
            {
                return lore;
            }

            set
            {
                lore = value;
            }
        }
        #endregion
    }
}
