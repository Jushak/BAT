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
using BAT_WPF.Views;
using BAT_WPF.Models;
using BAT_WPF.Logic;
using Microsoft.Win32;

namespace BAT_WPF.Views
{
    /// <summary>
    /// Interaction logic for Mainmenu.xaml
    /// </summary>
    public partial class Mainmenu : UserControl
    {
        Border parentBorder_;
        public Mainmenu(Border parent)
        {
            parentBorder_ = parent;
            InitializeComponent();
        }

        // Start a new game.
        private void Btn_StartNew_Click(object sender, RoutedEventArgs e)
        {
            FactionSetup setup = new FactionSetup( parentBorder_ );
            parentBorder_.Child = setup;
        }

        // Load an existing game.
        private void Btn_LoadGame_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML file (*.xml)|*.xml";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                GameSerializer loader = new GameSerializer();
                GameInfo info = loader.deserializeFile(openFileDialog.FileName);
                parentBorder_.Child = new GameScreen(info, new Logic.GameLogic(info), parentBorder_);
            }
        }

        // Navigate to options page.
        private void Btn_Options_Click(object sender, RoutedEventArgs e)
        {
            // TODO:
            // 1. Options page.
            // 2. Options file creation.
            // 3. Save/load options.
            Window notImplemented = new NotImplementedDialog();
            notImplemented.ShowDialog();
        }

        // Exit the application.
        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
