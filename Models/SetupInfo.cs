using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    /// <summary>
    /// Class used to store temporary info collected while setting up a new game.
    /// </summary>
    public class SetupInfo : InfoBase
    {
        ushort year;
        string factionName;
        Faith factionFaith;
        Int16 genderDominance;

        #region Constructors

        /// <summary>
        /// Basic constructor for SetupInfo.
        /// </summary>
        public SetupInfo()
        {
            Year = 101;
            FactionName = "";
            FactionFaith = new Faith();
            GenderDominance = 50;
        }

        #endregion

        #region Getters and setters

        public ushort Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string FactionName
        {
            get
            {
                return factionName;
            }

            set
            {
                factionName = value;
            }
        }

        public Faith FactionFaith
        {
            get
            {
                return factionFaith;
            }

            set
            {
                factionFaith = value;
            }
        }

        public short GenderDominance
        {
            get
            {
                return genderDominance;
            }

            set
            {
                genderDominance = value;
            }
        }

        #endregion

        #region Functions

        #endregion

    }
}
