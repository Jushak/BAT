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
    /// Interaction logic for GameScreen.xaml
    /// </summary>
    public partial class GameScreen : Page
    {
        GameInfo gameInfo;

        public GameScreen( GameInfo game )
        {
            InitializeComponent();
            Page current = new OverviewScreen();
            ViewsFrame.Content = current;
            gameInfo = game;
        }

        // Open Options-dialog
        private void BtnOptions_Click(object sender, RoutedEventArgs e)
        {
            OptionsDialog popup = new OptionsDialog();
            popup.ShowDialog();
        }

        // Change current frame page to Diplomacy screen.
        private void BtnDiplomacy_Click(object sender, RoutedEventArgs e)
        {
            Page current = new DiplomacyScreen();
            ViewsFrame.Content = current;
        }

        // Change current frame page to Trade screen.
        private void BtnTrade_Click(object sender, RoutedEventArgs e)
        {
            Page current = new TradeScreen();
            ViewsFrame.Content = current;
        }

        // Change current frame page to Militia screen.
        private void BtnMilitia_Click(object sender, RoutedEventArgs e)
        {
            Page current = new MilitiaScreen();
            ViewsFrame.Content = current;
        }

        // Change current frame page to Overview screen.
        private void BtnOverview_Click(object sender, RoutedEventArgs e)
        {
            Page current = new OverviewScreen();
            ViewsFrame.Content = current;
        }

        // Change current frame page to Faith screen.
        private void BtnFaith_Click(object sender, RoutedEventArgs e)
        {
            Page current = new FaithScreen();
            ViewsFrame.Content = current;
        }

        // Change current frame page to Exploration screen.
        private void BtnExploration_Click(object sender, RoutedEventArgs e)
        {
            Page current = new ExplorationScreen();
            ViewsFrame.Content = current;
        }

        private void BtnPass_Click(object sender, RoutedEventArgs e)
        {
            gameInfo.advanceSeason();
        }
    }
}
