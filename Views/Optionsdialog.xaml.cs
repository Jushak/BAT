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
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;
using BAT_WPF.Logic;

namespace BAT_WPF.Views
{
    /// <summary>
    /// Interaction logic for GameOptions.xaml
    /// </summary>
    public partial class OptionsDialog : Window
    {
        Border parentBorder;
        GameInfo gameInfo;

        public OptionsDialog( Border parent, GameInfo info )
        {
            parentBorder = parent;
            gameInfo = info;
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure? Any unsaved progress will be lost.", "Exit the game? ", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }            
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file (*.xml)|*.xml";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = gameInfo.FactionName + "_" + gameInfo.Year;
            if(saveFileDialog.ShowDialog() == true)
            {
                GameSerializer saver = new GameSerializer();
                saver.serializeFile(gameInfo, saveFileDialog.FileName);
            }
            this.Close();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML file (*.xml)|*.xml";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                GameSerializer loader = new GameSerializer();
                GameInfo info = loader.deserializeFile(openFileDialog.FileName);
                parentBorder.Child = new GameScreen( gameInfo, new Logic.GameLogic(), parentBorder);
                this.Close();
            }
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure? Any unsaved progress will be lost.", "Return to main menu? ", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                parentBorder.Child = new Mainmenu(parentBorder);
                this.Close();
            }
        }


        
    }
}
