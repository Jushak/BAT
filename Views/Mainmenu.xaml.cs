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

namespace BAT_WPF
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
            // TODO: 
            // 1. New game "flowchart" for pre-game decisions for your faction.
            // 2. Faction data generation based on decisions.
            // 3. Generate faction noble/leader pool

            // TEMP: Load up placeholder session for now.

            FactionSetup setup = new FactionSetup( parentBorder_ );

            //GameInfo gameInfo = new GameInfo();
            //GameScreen game = new GameScreen( gameInfo, _parentBorder );
            parentBorder_.Child = setup;
        }

        // Load an existing game.
        private void Btn_LoadGame_Click(object sender, RoutedEventArgs e)
        {
            // TODO:
            // 1. Save file creation.
            // 2. Load file dialogue.
            // 3. Save file parsing.

            // TEMP: Load up placeholder session for now.
            GameInfo gameInfo = new GameInfo();
            DataContext = gameInfo;
            GameScreen game = new GameScreen( gameInfo, parentBorder_ );
            //NavigationService.Navigate(game);
            parentBorder_.Child = game;
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
