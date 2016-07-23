using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    public class God : Actor
    {
        List<String> portfolio_;
        List<String> titles_;
        List<String> combatFeats_;
        List<String> favoredSkills_;
        UInt16 genderSplit_;
        Boolean priests_;
        Boolean priestesses_;

        #region Constructors
        public God()
            : base("TestGod")
        {
            portfolio_ = new List<String>();
            titles_ = new List<String>();
            combatFeats_ = new List<String>();
            favoredSkills_ = new List<String>();
            genderSplit_ = 50;
            priests_ = true;
            priestesses_ = true;
        }

        public God(string name) 
            : base(name)
        {
            portfolio_ = new List<String>();
            titles_ = new List<String>();
            combatFeats_ = new List<String>();
            favoredSkills_ = new List<String>();
            genderSplit_ = 50;
            priests_ = true;
            priestesses_ = true;
        }

        #endregion

        #region Getters and setters
        public List<string> Portfolio_
        {
            get
            {
                return portfolio_;
            }

            set
            {
                portfolio_ = value;
            }
        }

        public List<string> Titles_
        {
            get
            {
                return titles_;
            }

            set
            {
                titles_ = value;
            }
        }

        public List<string> CombatFeats_
        {
            get
            {
                return combatFeats_;
            }

            set
            {
                combatFeats_ = value;
            }
        }

        public List<string> FavoredSkills_
        {
            get
            {
                return favoredSkills_;
            }

            set
            {
                favoredSkills_ = value;
            }
        }

        public ushort GenderSplit_
        {
            get
            {
                return genderSplit_;
            }

            set
            {
                genderSplit_ = value;
            }
        }
        #endregion

    }
}
