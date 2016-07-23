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
using System.Windows.Shapes;

namespace BAT_WPF.Views
{
    /// <summary>
    /// Interaction logic for GameOptions.xaml
    /// </summary>
    public partial class OptionsDialog : Window
    {
        Border parentBorder_;

        public OptionsDialog( Border parent )
        {
            parentBorder_ = parent;
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure? Any unsaved progress will be lost.", "Exit the game? ", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }            
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Window notImplemented = new NotImplementedDialog();
            notImplemented.ShowDialog();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            Window notImplemented = new NotImplementedDialog();
            notImplemented.ShowDialog();
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure? Any unsaved progress will be lost.", "Return to main menu? ", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                parentBorder_.Child = new Mainmenu(parentBorder_);
                this.Close();
            }
        }

        protected virtual void OnNavButtonPressed()
        {

        }
    }
}
