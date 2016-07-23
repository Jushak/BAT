using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    public class SetupInfo : InfoBase
    {
        ushort year_;
        string factionName_;
        Faith factionFaith_;
        Int16 genderDominance_;

        

        #region Constructors

        public SetupInfo()
        {
            year_ = 101;
            factionName_ = "";
            factionFaith_ = new Faith();
            genderDominance_ = 50;
        }

        #endregion

        #region Getters and setters

        public ushort Year_
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

        public string FactionName_
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

        public Faith FactionFaith_
        {
            get
            {
                return factionFaith_;
            }

            set
            {
                factionFaith_ = value;
            }
        }

        public short GenderDominance_
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

        #endregion

    }
}
