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

        #region Constructors
        public God()
            : base("TestGod")
        {
            Portfolio_ = new List<String>();
            Titles_ = new List<String>();
            CombatFeats_ = new List<String>();
            FavoredSkills_ = new List<String>();
            UInt16 genderSplit_ = 50;
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
