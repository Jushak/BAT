using BAT_WPF.Logic;
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
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : UserControl
    {
        Border grandParentBorder_;
        GameInfo info_;
        GameLogic logic_;
        public GameView(GameInfo info, GameLogic logic, Border border)
        {
            InitializeComponent();
            info_ = info;
            logic_ = logic;
            grandParentBorder_ = border;
            SubViewsBorder.Child = new OverviewScreen();
        }

        // Open Options-dialog
        private void BtnOptions_Click(object sender, RoutedEventArgs e)
        {
            OptionsDialog popup = new OptionsDialog(grandParentBorder_, info_);
            popup.ShowDialog();
        }

        // Change current frame page to Agriculture screen.
        private void BtnAgriculture_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new AgricultureScreen();
            SubViewsBorder.Child = current;
        }

        // Change current frame page to Diplomacy screen.
        private void BtnDiplomacy_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new DiplomacyScreen();
            SubViewsBorder.Child = current;
        }

        // Change current frame page to Trade screen.
        private void BtnTrade_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new TradeScreen();
            SubViewsBorder.Child = current;
        }

        // Change current frame page to Militia screen.
        private void BtnMilitia_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new MilitiaScreen();
            SubViewsBorder.Child = current;
        }

        // Change current frame page to Overview screen.
        private void BtnOverview_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new OverviewScreen();
            SubViewsBorder.Child = current;
        }

        // Change current frame page to Faith screen.
        private void BtnFaith_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new FaithScreen();
            SubViewsBorder.Child = current;
        }

        // Change current frame page to Exploration screen.
        private void BtnExploration_Click(object sender, RoutedEventArgs e)
        {
            UserControl current = new ExplorationScreen();
            SubViewsBorder.Child = current;
        }

        private void BtnPass_Click(object sender, RoutedEventArgs e)
        {
            info_.advanceSeason();
            Random rnd = new Random();
            if ( rnd.Next(1, 10) > 5)
            {
                grandParentBorder_.Child = new EventView(info_, logic_, grandParentBorder_);
            }
        }
    }
}
