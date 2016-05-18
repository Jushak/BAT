using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    /*
     * Base class for actors - people, gods, named monsters etc. - in the game.
     */
    public class Actor
    {
        string name_;

        #region Constructors
        public Actor()
        {
            Name_ = "TestActor";
        }

        public Actor(string name)
        {
            Name_ = name;
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
        #endregion
    }
}
