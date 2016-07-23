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
        UInt16 index_;
        List<UserControl> setupControls_;
        Border parentBorder_;
        SetupInfo setup_;

        public FactionSetup( Border parent )
        {
            setup_ = new SetupInfo();
            setupControls_ = new List<UserControl>();
            setupControls_.Add(new IntroductionScreen());
            setupControls_.Add(new FinalizeScreen( setup_ ));
            DataContext = setup_;
            index_ = 0;
            InitializeComponent();
            ViewsBorder.Child = setupControls_.ElementAt(index_);
            btnBack.IsEnabled = false;
            btnStart.IsEnabled = false;
            btnStart.Visibility = System.Windows.Visibility.Hidden; 
            parentBorder_ = parent;
        }

        // Navigate back to earlier setup page. Enable/Disable buttons as necessary.
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            index_--;
            if ( index_ == 0 )
            {
                btnBack.IsEnabled = false;
                if ( btnNext.IsEnabled == false )
                {
                    btnNext.IsEnabled = true;
                    btnStart.Visibility = System.Windows.Visibility.Hidden;
                }
            }
            ViewsBorder.Child = setupControls_.ElementAt(index_);
        }

        // Navigate to next setup page. Enable / Disable buttons as necessary.
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            index_++;
            if ((index_ >= setupControls_.Count() - 1))
            {
                btnNext.IsEnabled = false;
                if (btnBack.IsEnabled == false)
                {
                    btnBack.IsEnabled = true;
                    btnStart.IsEnabled = true;
                    btnStart.Visibility = System.Windows.Visibility.Visible;
                }
            }
            ViewsBorder.Child = setupControls_.ElementAt(index_);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if ( setup_.FactionName_.Equals("") )
            {
                setup_.FactionName_ = "PlaceHolderName";
            }
            GameInfo gameInfo = new GameInfo( setup_.FactionName_, setup_.Year_ );
            GameLogic gameLogic = new GameLogic(gameInfo);
            DataContext = gameInfo;
            GameScreen game = new GameScreen(gameInfo, gameLogic, parentBorder_);
            parentBorder_.Child = game;
        }
    }
}
