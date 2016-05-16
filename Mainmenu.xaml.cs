﻿using System;
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

namespace BAT_WPF
{
    /// <summary>
    /// Interaction logic for Mainmenu.xaml
    /// </summary>
    public partial class Mainmenu : Page
    {    

        public Mainmenu()
        {
            InitializeComponent();
        }

        // Start a new game.
        private void Btn_StartNew_Click(object sender, RoutedEventArgs e)
        {
            // TODO: 
            // 1. New game "flowchart" for pre-game decisions for your faction.
            // 2. Faction data generation based on decisions.
            // 3. Generate faction noble/leader pool
            GameScreen game = new GameScreen();
            NavigationService.Navigate(game);
        }

        // Load an existing game.
        private void Btn_LoadGame_Click(object sender, RoutedEventArgs e)
        {
            // TODO:
            // 1. Save file creation.
            // 2. Load file dialogue.
            // 3. Save file parsing.
            GameScreen game = new GameScreen();
            NavigationService.Navigate(game);
        }

        // Navigate to options page.
        private void Btn_Options_Click(object sender, RoutedEventArgs e)
        {
            // TODO:
            // 1. Options page.
            // 2. Options file creation.
            // 3. Save/load options.
        }

        // Exit the application.
        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
