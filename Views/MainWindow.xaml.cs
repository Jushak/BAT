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
using System.Globalization;
using System.Windows.Markup;
using System.Threading;

namespace BAT_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag);
            var culture = CultureInfo.CurrentCulture.Name;
            ResourceDictionary dict = new ResourceDictionary();
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                default:
                    dict.Source = new Uri("..\\Resources\\StringResources.xaml",
                                    UriKind.Relative);
                    break;
            }
            this.Resources.MergedDictionaries.Add(dict);
    
            MainBorder.Child = new Mainmenu(MainBorder);
        }
    }
}
