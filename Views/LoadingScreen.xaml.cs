using BAT_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace BAT_WPF.Views
{
    /// <summary>
    /// Interaction logic for LoadingScreen.xaml
    /// </summary>
    public partial class LoadingScreen : UserControl
    {
        Border parentBorder_;
        private DispatcherTimer loadingTimer;
        private string Loading = Application.Current.FindResource("loading") as string;
        
        public LoadingScreen( Border parent)
        {
            parentBorder_ = parent;
            InitializeComponent();
            loadingTimer = new DispatcherTimer();
            loadingTimer.Interval = TimeSpan.FromMilliseconds(500);
            loadingTimer.Tick += new EventHandler(loadingTimer_Tick);
            loadingTimer.Start();
        }

        void loadingTimer_Tick(object sender, EventArgs e)
        {
            int dotsCount = lblLoading.Content.ToString().Replace(Loading, string.Empty).Length;
            if (dotsCount < 3 )
            {
                dotsCount++;
            }
            else
            {
                dotsCount = 0;
            }

            lblLoading.Content = Loading.PadRight(Loading.Length + dotsCount, '.');
        }
    }
}
