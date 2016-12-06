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
        string name;

        #region Constructors
        public Actor()
        {
            name = "TestActor";
        }

        public Actor(string actorName)
        {
            name = actorName;
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
        #endregion
    }
}
