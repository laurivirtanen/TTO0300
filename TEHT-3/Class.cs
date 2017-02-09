using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEHT_3
{
    class Lotto
    {

        Random rand = new Random();
        private int randomNumber;
        public int[,] allthemdraws;
        public int game = 7;
        private int maxNumber;

        public string Eurojackpot(int draws, string lot)
        {
            rand = new Random();
            game = 5;
            maxNumber = 51;

            int[,] allDraws = new int[draws, game];

            int[] draw = new int[game];
            for (int i = 0; i < draws; i++)
            {
                lot += "Row " + (i + 1) + " : ";
                for (int j = 0; j < game; j++)
                {
                    do
                    {
                        randomNumber = rand.Next(1, maxNumber);
                    } while (draw.Contains(randomNumber));
                    allDraws[i, j] = randomNumber;
                    draw[j] = randomNumber;
                }
                Array.Sort(draw);

                for (int h = 0; h < draw.Length; h++)
                {
                    lot += draw[h].ToString();
                    if (h < game - 1)
                    {
                        lot += ", ";
                    }
                }
                int[] stars = new int[2];
                stars[0] = rand.Next(1, 11);
                do
                {
                    stars[1] = rand.Next(1, 11);
                } while (stars[1] == stars[0]);
                Array.Sort(stars);
                lot += "*" + stars[0] + ", " + stars[1];
                lot += "\n";

            }

            allthemdraws = allDraws;
            return lot;
        }

        public string VikingLotto(int draws, string lot)
        {

            rand = new Random();
            game = 6;
            maxNumber = 40;
            int[] draw = new int[game];
            int[,] allDraws = new int[draws, game];
            int randomNumber;
            for (int i = 0; i < draws; i++)
            {
                lot += "Row " + (i + 1) + " : ";
                for (int j = 0; j < game; j++)
                {
                    do
                    {
                      randomNumber = rand.Next(1, maxNumber);
                    } while (draw.Contains(randomNumber));

                    allDraws[i, j] = randomNumber;
                    draw[j] = randomNumber;
                }

                Array.Sort(draw);

                for (int h = 0; h < game; h++)
                {
                    lot += draw[h].ToString();
                    if (h < game - 1)
                    {
                        lot += ", ";
                    }
                }
                lot += "\n";
            }
            allthemdraws = allDraws;
            return lot;
        }

        public string NormalLotto(int draws, string lot)
        {
            rand = new Random();
            game = 7;
            maxNumber = 40;
            int[] draw = new int[game];
            int[,] allDraws = new int[draws, game];
            for (int i = 0; i < draws; i++)
            {


                lot += "Row " + (i + 1) + " : ";
                for (int j = 0; j < game; j++)
                {
                    do
                    {
                        randomNumber = rand.Next(1, maxNumber);
                    } while (draw.Contains(randomNumber));

                    allDraws[i, j] = randomNumber;
                    draw[j] = randomNumber;
                }

                Array.Sort(draw);

                for (int h = 0; h < game; h++)
                {
                    lot += draw[h].ToString();
                    if (h < game - 1)
                    {
                        lot += ", ";
                    }
                }
                lot += "\n";

            }
            allthemdraws = allDraws;
            return lot;
        }

        public string Lottery(string lot, int draws, int game)
        {
            switch (game)
            {
                case 1:
                    return NormalLotto(draws, lot);
                case 2:
                    return VikingLotto(draws, lot);
                case 3:
                    return Eurojackpot(draws, lot);
                default:
                    break;
            }


            return "ERROR";
        }


        public string CheckWins()
        {
            int tulos = 0;
            int[] result = new int[game];
            string resultPrint = "";
            int z;

            for (int i = 0; i < game; i++)
            {
                do
                {
                    z = rand.Next(1, 40);
                } while (result.Contains(z));
                result[i] = z;
                
            }

            Array.Sort(result);
            foreach (var item in result)
            {
                resultPrint += item.ToString() + " ";
            }

            for (int i = 0; i < allthemdraws.GetLength(0); i++)
            {
                int oikein = 0;
                for (int j = 0; j < allthemdraws.GetLength(1); j++)
                {
                    if (result.Contains(allthemdraws[i, j]))
                    {
                        oikein++;
                    }
                }

                if (oikein == 7) { tulos += 2400000; resultPrint += "\n" + oikein + " oikein, voitit 2 400 000€"; resultPrint += oikein + " oikein, voitit 2 400 000€"; }
                else if (oikein == 6) { tulos += 1000; }   //scvResult.Content +="\n"+ oikein + " oikein, voitit 1000€"; MessageBox.Show(oikein + " oikein, voitit 1000€"); }
                else if (oikein == 5) { tulos += 50; }   // }// scvResult.Content += "\n" + oikein + " oikein, voitit 50€"; MessageBox.Show(oikein + " oikein, voitit 50€"); }
                else if (oikein == 4) { tulos += 10; }   // }scvResult.Content += "\n" + oikein + " oikein, voitit 10€"; MessageBox.Show(oikein + " oikein, voitit 10€"); }
                else if (oikein == 3) { tulos += 1; }
                {

                }
            }
            resultPrint += "\nVoitit: " + tulos.ToString() + " euroa" +"\nKäytit: "+ allthemdraws.GetLength(0).ToString() +" euroa";
            return resultPrint;
        }
      }
    }

