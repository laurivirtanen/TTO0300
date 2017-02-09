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

namespace TEHT_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string lottoPrint = "";

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {

            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("file:///D:/K8455/TTO0300/TEHT-3/Viking-Lotto.PNG"));
            myBrush.ImageSource = image.Source;





            Lotto lott = new Lotto();
            int x = 2;
            Int32.TryParse(txtGames.Text.ToString(), out x);
            if (lot.IsSelected==true)
            {
                image.Source = new BitmapImage(new Uri("file:///D:/K8455/TTO0300/TEHT-3/lotto.PNG"));
                myBrush.ImageSource = image.Source;
                gridi.Background = myBrush;
                txtPrint.Text = lott.Lottery(lottoPrint, x, 7);
            }
            else if (vlot.IsSelected == true)
            {
                gridi.Background = myBrush;
                txtPrint.Text = lott.Lottery(lottoPrint, 55, 6);
            }
            else if (elot.IsSelected == true)
            {
                image.Source = new BitmapImage(new Uri("file:///D:/K8455/TTO0300/TEHT-3/eurojackpot.PNG"));
                myBrush.ImageSource = image.Source;
                gridi.Background = myBrush;
                txtPrint.Text = lott.Lottery(lottoPrint, x, 5);
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtPrint.Text = "";
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
