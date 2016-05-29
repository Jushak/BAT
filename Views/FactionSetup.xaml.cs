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

        public FactionSetup( Border parent )
        {
            setupControls_ = new List<UserControl>();
            setupControls_.Add(new IntroductionScreen());
            setupControls_.Add(new FinalizeScreen());
            index_ = 0;
            InitializeComponent();
            ViewsBorder.Child = setupControls_.ElementAt(index_);
            btnBack.IsEnabled = false;
            btnBack.IsEnabled = false;
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
                }
            }
            ViewsBorder.Child = setupControls_.ElementAt(index_);
        }
    }
}
