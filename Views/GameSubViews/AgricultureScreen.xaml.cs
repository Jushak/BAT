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
    /// Interaction logic for AgricultureScreen.xaml
    /// </summary>

    /* 
     * Agriculture is complex thing, so some real world equivalents need to be considered.
     * 
     * Notes on grazing: https://en.wikipedia.org/wiki/Livestock_grazing_comparison
     * 
     * Using The John Nix Farm Management Pocketbook values. Thus 1 Livestock Unit (LU) = 1 Cow = 0.8 horse = 0.08 sheep = 0.2 pigs. 
     * Overgrazing will be considered to happen when the value of LU / hectares goes over certainvalue - OvergrazingLimit in
     * code - which will lead to herds becoming malnourished and overcrowded, hurting breeding.
     * 
     * Notes on farming:
     * http://history.stackexchange.com/questions/9044/what-was-the-size-of-surface-of-a-cereal-crop-needed-per-man-per-year-during-the
     * https://en.wikipedia.org/wiki/British_Agricultural_Revolution
     * https://en.wikipedia.org/wiki/Hide_(unit)
     * 
     * Going by the stackexchange answer, food consumption used will be 14 bushels / child and 24 / adult.
     * Due to possibly dubious origin of the Carolingian baseline in the stackexchange the net yield will be taken from 1250-1299 britain:
     * 8.7 for Wheat, 10.7 for Rye 10.3 for Barley in bushels / acre.
     * 
     * To take account for varying quality of land an English unit of "hide" will also be used to represent land. One hide" is traditionally
     * taken to be 120 acres or 48 hectares, but it's really an unit of tax assessment. For our purposes, hide is used to obscure the exact
     * amount of land and simply used to describe amount of "ideal land" that would yield our values described above.
     * 
     * Thus 1 hide provides the following:
     * 
     * Pasture for 48 cows or 150 horses or 60 sheep or 600 sheep or 2400 pigs
     * Crop fields providing 1044 bushels of wheat or 1284 bushels of rye or 1236 bushels of Barley in an ideal year, before any modifiers.
     * 
     */

    public partial class AgricultureScreen : UserControl
    { 
        public AgricultureScreen()
        {
            InitializeComponent();
        }
    }
}
