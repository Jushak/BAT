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
using BAT_WPF.Views;
using BAT_WPF.Models;

namespace BAT_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private delegate void LoaderDelegate();
        LoaderDelegate loaderDelegate;
        Thread loadingThread;

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
            loaderDelegate = new LoaderDelegate(this.loadingDone);
            MainBorder.Child = new LoadingScreen(MainBorder);
        }


        private void loadingDone()
        {
            MainBorder.Child = new Mainmenu(MainBorder);
        }

        void dataLoader()
        {
            // Test: Simulate loading all the data by sleeping
            Thread.Sleep(5000);
            // TODO: Add all the items that need to load.
            GameData data = GameData.Instance;
            this.Dispatcher.Invoke(loadingDone);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadingThread = new Thread(dataLoader);
            loadingThread.Start();
        }
    }
}
