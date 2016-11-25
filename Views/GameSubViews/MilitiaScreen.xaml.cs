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
     * Building / dismantling military buildings
     * Managing patrol strengths
     * Recruiting / dismissing elite warriors
     * Military decisions (who fights? (Only) free (wo)men? Slaves? Undead?
     * Show more options depending on faith / gods?
     */

    /// <summary>
    /// Interaction logic for MilitiaScreen.xaml
    /// </summary>
    public partial class MilitiaScreen : UserControl
    {
        public MilitiaScreen()
        {
            InitializeComponent();
        }

        private void btnHire_Click(object sender, RoutedEventArgs e)
        {
            Window hireScreen = new HireScreen();
            hireScreen.DataContext = this.DataContext;
            hireScreen.ShowDialog();
        }

        private void btnDismiss_Click(object sender, RoutedEventArgs e)
        {
            Window dismissScreen = new DismissScreen();
            dismissScreen.DataContext = this.DataContext;
            dismissScreen.ShowDialog();
        }

        private void btnRaid_Click(object sender, RoutedEventArgs e)
        {
            Window notImplemented = new NotImplementedDialog();
            notImplemented.ShowDialog();
        }

        private void btnBattle_Click(object sender, RoutedEventArgs e)
        {
            Window notImplemented = new NotImplementedDialog();
            notImplemented.ShowDialog();
        }
    }
}
