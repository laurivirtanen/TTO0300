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

namespace TEHT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        private float leveysMm = 0f;
        private float korkeusMm = 0f;
        private float pinAla;
        private float kpuu = 45;
        private float karpir = 0f;
        private float test;

        public MainWindow()
        {
            
            pintaAla();
            KarmiPinnat();
            InitializeComponent();
            karmil.Text = kpuu.ToString();
        }

        private float pintaAla()
        {
            pinAla = (leveysMm * korkeusMm);
            return pinAla;
        }

        private float karmiPiiri()
        {
            karpir = (leveysMm * 2 + korkeusMm * 2)/10;
            return karpir;
        }

        private float KarmiPinnat()
        {
            test = ((leveysMm * korkeusMm) / 10) + ((kpuu * korkeusMm) * 2 + (kpuu * leveysMm) * 2)/10 - (kpuu * 8)/10;

            return test;
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if (float.TryParse(leveys.Text, out leveysMm) && float.TryParse(korkeus.Text, out korkeusMm) && float.TryParse(karmil.Text, out kpuu))
            {
                pintaAla();
                KarmiPinnat();
                karmiPiiri();

                IkkunaPa.Text = test.ToString("F00")+ " CM^2";
                LasinPa.Text = ((leveysMm * korkeusMm) / 10).ToString("F00") + " CM^2"; 
                KarmiPiiri.Text = karpir.ToString("F00")+" cm";
            }
        }
    }
}
