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
    /// Interaction logic for EventView.xaml
    /// </summary>
    public partial class EventView : UserControl
    {
        GameInfo gameInfo;
        GameLogic gameLogic;
        Border parentBorder;

        public EventView(GameInfo info, GameLogic logic, Border parent )
        {
            InitializeComponent();
            gameInfo = info;
            gameLogic = logic;
            parentBorder = parent;
        }

        private void btnProceed_Click(object sender, RoutedEventArgs e)
        {
            ((Border)(this.Parent)).Child = new GameScreen( gameInfo, gameLogic, parentBorder );
        }
    }
}
