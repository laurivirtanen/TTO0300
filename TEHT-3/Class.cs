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

        public string Lottery(string lot, int draws, int game)
        {
            int[] t = new int[game];
            int x;
            for (int i = 0; i < draws; i++)
            {
                lot+="Row " +(i+1)+" : ";
                for (int j = 0; j < game; j++)
                {
                    do
                    {
                        x = rand.Next(1, 40);
                    } while (t.Contains(x));
                    t[j] = x;
                }

                Array.Sort(t);

                for (int h = 0; h < game; h++)
                {
                    lot += t[h].ToString();
                    lot += ", ";
                }
                lot += "\n";
            }
            return lot;

        }
    }
}
