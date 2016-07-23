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

namespace BAT_WPF
{    
    /// <summary>
    /// Interaction logic for GameScreen.xaml
    /// </summary>
    public partial class GameScreen : UserControl
    {
        GameInfo gameInfo_;
        GameLogic gameLogic_;
        Border parentBorder_;

        public GameScreen( GameInfo info, GameLogic logic, Border parent )
        {
            InitializeComponent();
            gameInfo_ = info;
            gameLogic_ = logic;
            parentBorder_ = parent;

            DataContext = gameInfo_;
            ViewsBorder.Child = new OverviewScreen(gameInfo_);
        }

        // Open Options-dialog
        private void BtnOptions_Click(object sender, RoutedEventArgs e)
        {
            OptionsDialog popup = new OptionsDialog( parentBorder_ );
            popup.ShowDialog();
        }

        // Change current frame page to Diplomacy screen.
        private void BtnDiplomacy_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new DiplomacyScreen(gameInfo_);
            ViewsBorder.Child = current;
        }

        // Change current frame page to Trade screen.
        private void BtnTrade_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new TradeScreen(gameInfo_);
            ViewsBorder.Child = current;
        }

        // Change current frame page to Militia screen.
        private void BtnMilitia_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new MilitiaScreen(gameInfo_);
            ViewsBorder.Child = current;
        }

        // Change current frame page to Overview screen.
        private void BtnOverview_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new OverviewScreen(gameInfo_);
            ViewsBorder.Child = current;
        }

        // Change current frame page to Faith screen.
        private void BtnFaith_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new FaithScreen(gameInfo_);
            ViewsBorder.Child = current;
        }

        // Change current frame page to Exploration screen.
        private void BtnExploration_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new ExplorationScreen(gameInfo_);
            ViewsBorder.Child = current;
        }

        private void BtnPass_Click(object sender, RoutedEventArgs e)
        {
            gameInfo_.advanceSeason();
        }
    }
}
