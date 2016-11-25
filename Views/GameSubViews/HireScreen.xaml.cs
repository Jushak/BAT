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
using System.Windows.Shapes;

namespace BAT_WPF.Views
{
    /// <summary>
    /// Interaction logic for RecruitScreen.xaml
    /// </summary>
    public partial class HireScreen : Window
    {
        public HireScreen()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = HireSlider.GetBindingExpression(Slider.ValueProperty);
            be.UpdateSource();

            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
