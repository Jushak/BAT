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
        int age;
        // What faith the leader follows, if any.
        string faith;
        char gender;
        // The main god(s) the leader follows.
        List<String> gods;
        // Skills possessed by the leader, with numerical value going from 0 (no skill) to 6 (heroic).
        Skill leadership;
        Skill bargaining;
        Skill combat;
        Skill custom;
        Skill magic;
        Skill animals;
        Skill plants;
        Skill lore;

        string imageName;

        #region Constructors

        /// <summary>
        /// Basic constructor for a Leader with pre-filled values.
        /// </summary>
        public Leader()
            : base("TestLeader")
        {
            age = 18;
            faith = "";
            char gender = 'm';
            gods = new List<string>();
            Skill leadership = Skill.mediocre;
            Skill bargaining = Skill.mediocre;
            Skill combat = Skill.mediocre;
            Skill custom = Skill.mediocre;
            Skill magic = Skill.mediocre;
            Skill animals = Skill.mediocre;
            Skill plants = Skill.mediocre;
            Skill lore = Skill.mediocre;

            ImageName = "";
        }

        /// <summary>
        /// Constructor for creating a Leader for pre-existing data.
        /// </summary>
        /// <param name="leaderAge">Age of the Leader.</param>
        /// <param name="leaderName">Name of the Leader.</param>
        /// <param name="leaderFaith">Faith of the Leader.</param>
        /// <param name="leaderGender">Gender of the Leader.</param>
        /// <param name="LeaderGods">What gods the Leader worships, if any.</param>
        /// <param name="leaderLeadership">Leadership-Skill of the Leader.</param>
        /// <param name="leaderBargaining">Bargaining-Skill of the Leader.</param>
        /// <param name="leaderCombat">Combat-Skill of the Leader.</param>
        /// <param name="leaderCustom">Custom-Skill of the Leader.</param>
        /// <param name="leaderMagic">Magic-Skill of the Leader.</param>
        /// <param name="leaderAnimals">Animals-Skill of the Leader.</param>
        /// <param name="leaderPlants">Plants-Skill of the Leader.</param>
        /// <param name="leaderLore">Lore-Skill of the Leader.</param>
        /// <param name="leaderImageName">Name of the image used to describe the Leader.</param>
        public Leader( int leaderAge, string leaderName, string leaderFaith, char leaderGender, List<string> LeaderGods,
            Skill leaderLeadership, Skill leaderBargaining, Skill leaderCombat, Skill leaderCustom, Skill leaderMagic, 
            Skill leaderAnimals, Skill leaderPlants, Skill leaderLore, string leaderImageName)
            : base(leaderName)
        {
            age = leaderAge;
            faith = leaderFaith;
            gender = leaderGender;
            gods = LeaderGods;
            Skill leadership = leaderLeadership;
            Skill bargaining = leaderBargaining;
            Skill combat = leaderCombat;
            Skill custom = leaderCustom;
            Skill magic = leaderMagic;
            Skill animals = leaderAnimals;
            Skill plants = leaderPlants;
            Skill lore = leaderLore;
            ImageName = leaderImageName;
        } 

        /// <summary>
        /// Basic constructor for a Leader with just name given. Assumes 18 years old male Actor with all skills at None(0).
        /// </summary>
        /// <param name="name">Name of the Leader.</param>
        public Leader( string name ) : base(name)
        {
            age = 18;
            faith = "";
            gender = 'm';
            gods = new List<string>();
            Skill leadership = Skill.none;
            Skill bargaining = Skill.none;
            Skill combat = Skill.none;
            Skill custom = Skill.none;
            Skill magic = Skill.none;
            Skill animals = Skill.none;
            Skill plants = Skill.none;
            Skill lore = Skill.none;
            ImageName = "";
        }
        #endregion

        #region Getters and setters
        public string MyFaith
        {
            get
            {
                return faith;
            }

            set
            {
                faith = value;
            }
        }

        public List<string> MyGods
        {
            get
            {
                return gods;
            }

            set
            {
                gods = value;
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

        public char Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string ImageName
        {
            get
            {
                return imageName;
            }

            set
            {
                imageName = value;
            }
        }
        #endregion
    }
}
