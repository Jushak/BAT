using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    enum Skill { none, poor, mediocre, good, great, superior, heroic };

    /* 
     * Model for leaders - a catch-all term for nobles and other upper-class personage that form
     * the leadership of the faction. Form the pool of characters eligible for faction's council.
     */
    public class Leader : Actor
    {
        // What faith the leader follows, if any.
        Faith myFaith;
        // The main god(s) the leader follows.
        List<God> myGods;
        // Skills possessed by the leader, with numerical value going from 0 (no skill) to 6 (heroic).
        Skill leadership;
        Skill nargaining;
        Skill combat;
        Skill custom;
        Skill magic;
        Skill animals;
        Skill plants;
        Skill lore;

        public Leader()
            : base("TestLeader")
        {

        }

        #region Getters and setters
        internal Faith MyFaith
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

        internal List<God> MyGods
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

        internal Skill Leadership
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

        internal Skill Nargaining
        {
            get
            {
                return nargaining;
            }

            set
            {
                nargaining = value;
            }
        }

        internal Skill Combat
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

        internal Skill Custom
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

        internal Skill Magic
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

        internal Skill Animals
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

        internal Skill Plants
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

        internal Skill Lore
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
