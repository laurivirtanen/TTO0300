using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // for observable collection
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
using JAMK.ICT;

namespace DataBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    

        
    public partial class MainWindow : Window
    {
        //useampi metodi-tapahtumankäsittelijä tulee käsittelemään näitä muuttujia
        // määritellään luokan tasolle luokan jäsenmuuttujiksi
        HockeyLeague liiga;
        ObservableCollection<HockeyTeam> joukkueet;
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }
        
        private void IniMyStuff()
        {
            //Tänne kootusti omien kotrollien alustukset
            List<string> muuvi = new List<string>();
            muuvi.Add("Halloween");
            muuvi.Add("Jaws");
            muuvi.Add("Star Wars");

            cmbMovies.ItemsSource = muuvi;

            liiga = new HockeyLeague();
            joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;

        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //määritellään StackPanelin DataContext
            //Demo1: DataContextina on olio
            //HockeyTeam tiimi = new HockeyTeam("KeuPa", "Keuruu");
            //spRight.DataContext = tiimi;

            //demo2 kytketään oliokokoelman 1. olioon

            spRight.DataContext = joukkueet[counter];
            
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            if(counter > 4) { counter = 0; }
            spRight.DataContext = joukkueet[counter];
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            counter--;
            if (counter < 0) { counter = 4; }
            spRight.DataContext = joukkueet[counter];
        }
    }
}
