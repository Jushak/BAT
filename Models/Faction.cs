using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT_WPF.Models
{
    /*
     * Model for faction-related data for other factions in the world.
     */
    public class Faction
    {
        string name_;
        Faith faith_;
        List<Leader> leaders_;
        List<Leader> councilors_;
    }
}
