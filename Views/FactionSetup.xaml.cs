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
    /// Interaction logic for FactionSetup.xaml
    /// </summary>
    public partial class FactionSetup : UserControl
    {
        UInt16 index;
        List<UserControl> setupControls;
        Border parentBorder;
        SetupInfo setupInfo;

        public FactionSetup( Border parent )
        {
            setupInfo = new SetupInfo();
            setupControls = new List<UserControl>();
            setupControls.Add(new IntroductionScreen());
            setupControls.Add(new FinalizeScreen(setupInfo));
            DataContext = setupInfo;
            index = 0;
            InitializeComponent();
            ViewsBorder.Child = setupControls.ElementAt(index);
            btnBack.IsEnabled = false;
            btnStart.IsEnabled = false;
            btnStart.Visibility = System.Windows.Visibility.Hidden; 
            parentBorder = parent;
        }

        // Navigate back to earlier setup page. Enable/Disable buttons as necessary.
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            index--;
            if ( index == 0 )
            {
                btnBack.IsEnabled = false;
                if ( btnNext.IsEnabled == false )
                {
                    btnNext.IsEnabled = true;
                    btnStart.Visibility = System.Windows.Visibility.Hidden;
                }
            }
            ViewsBorder.Child = setupControls.ElementAt(index);
        }

        // Navigate to next setup page. Enable / Disable buttons as necessary.
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if ((index >= setupControls.Count() - 1))
            {
                btnNext.IsEnabled = false;
                if (btnBack.IsEnabled == false)
                {
                    btnBack.IsEnabled = true;
                    btnStart.IsEnabled = true;
                    btnStart.Visibility = System.Windows.Visibility.Visible;
                }
            }
            ViewsBorder.Child = setupControls.ElementAt(index);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (setupInfo.FactionName.Equals("") )
            {
                setupInfo.FactionName = "PlaceHolderName";
            }
            GameInfo gameInfo = new GameInfo(setupInfo.FactionName, setupInfo.Year );
            GameLogic gameLogic = new GameLogic();
            DataContext = gameInfo;
            GameScreen game = new GameScreen(gameInfo, gameLogic, parentBorder);
            parentBorder.Child = game;
        }
    }
}
