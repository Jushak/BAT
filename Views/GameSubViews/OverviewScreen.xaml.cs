using BAT_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BAT_WPF.Views
{
    /*
     * TODO:
     * Show extra information about the faction
     * See & change the number of specialist jobs (traders, hunters, crafters etc.)
     * Reorganize faction council
     */

    /// <summary>
    /// Interaction logic for OverviewScreen.xaml
    /// </summary>
    public partial class OverviewScreen : UserControl
    {
        public OverviewScreen( GameInfo gameinfo )
        {
            DataContext = gameinfo;
            InitializeComponent();
        }
    }
}
