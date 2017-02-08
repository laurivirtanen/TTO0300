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
/// <summary>
/// Tee sovellus, jossa käyttäjältä voidaan kysyä käyttäjätunnus ja salasana.
/// Tavoitteena on oppia Grid-kontrollin käyttöä eli älä sijoita kontrolleja 
/// Margin-määreiden avulla vapaasti, vaan käytä layoutin suunnittelussa apuna 
/// Grid-, GridDefinitions-, RowDefinitions-, ColumnDefinitions-määreitä.
/// Keskitä muodostamasi Grid keskelle näyttölaitetta. 
/// Tulosta käyttäjätunnus ja salasana Visual Studion Output-ikkunaan
/// (vihje: Debug.WriteLine();) sen jälkeen kun Login-painiketta on painettu.
/// </summary>



namespace TEHT_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
