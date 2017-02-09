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
        Image image = new Image();
        ImageBrush myBrush = new ImageBrush();
        Lotto lott = new Lotto();

        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            

            //Lotto lott = new Lotto();
            int x = 0;
            Int32.TryParse(txtGames.Text.ToString(), out x);
            if (lot.IsSelected == true)
            {
                scvResult.Content = lott.Lottery(lottoPrint, x, 1);
            }
            else if (vlot.IsSelected == true)
            {
               
                scvResult.Content = lott.Lottery(lottoPrint, x, 2);
            }
            else if (elot.IsSelected == true)
            {
                scvResult.Content = lott.Lottery(lottoPrint, x, 3);
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            scvResult.Content = "";
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lot.IsSelected == true)
            {
                image.Source = new BitmapImage(new Uri("http://lottonetti.net/wp-content/uploads/2016/04/veikkaus-lotto-logo.png"));
                myBrush.ImageSource = image.Source;
                gridi.Background = myBrush;
            }
            else if (vlot.IsSelected == true)
            {
                image.Source = new BitmapImage(new Uri("https://i1.wp.com/www.balkaneu.com/wp-content/uploads/2016/07/Euros.jpg?fit=565%2C424"));
                myBrush.ImageSource = image.Source;
                gridi.Background = myBrush;
            }
            else if (elot.IsSelected == true)
            {
                image.Source = new BitmapImage(new Uri("https://media.jumbolotto.de/00ca1e8/images/pub/meta/de/eurojackpot.jpg"));
                myBrush.ImageSource = image.Source;
                gridi.Background = myBrush;
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lott.CheckWins());
            /*
            try
            {
                int tulos = 0;
                Random test = new Random();
                int[] result = new int[lott.game];
                int z;

                for (int i = 0; i < lott.game; i++)
                {
                    do
                    {
                        z = test.Next(1, 40);
                    } while (result.Contains(z));
                    result[i] = z;
                }

                    scvResult.Content = "";
                for (int i = 0; i < lott.allthemdraws.GetLength(0); i++)
                {
                    int oikein = 0;
                    for (int j = 0; j < lott.allthemdraws.GetLength(1); j++)
                    {
                        if (result.Contains(lott.allthemdraws[i, j]))
                        {
                            oikein++;
                        }
                    }

                    if (oikein == 7) { tulos += 2400000; scvResult.Content += "\n" + oikein + " oikein, voitit 2 400 000€"; MessageBox.Show(oikein + " oikein, voitit 2 400 000€"); }
                    else if (oikein == 6) { tulos += 1000; }   //scvResult.Content +="\n"+ oikein + " oikein, voitit 1000€"; MessageBox.Show(oikein + " oikein, voitit 1000€"); }
                    else if (oikein == 5) { tulos += 50; }   // }// scvResult.Content += "\n" + oikein + " oikein, voitit 50€"; MessageBox.Show(oikein + " oikein, voitit 50€"); }
                    else if (oikein == 4) { tulos += 10; }   // }scvResult.Content += "\n" + oikein + " oikein, voitit 10€"; MessageBox.Show(oikein + " oikein, voitit 10€"); }

                    { 

                }
            }
                MessageBox.Show("Voitit: " + tulos.ToString()) + " euroa";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        
    }
}
