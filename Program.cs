using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitiftoplam = 0;
            int negatiftoplam = 0;

            for (int i = 0; ; i++)
            {
                Console.Write("Sayı girişi yapınız (Durdurmak icin '0' yazın.)  :  ");

                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi != 0)
                {
                    if (sayi < 0)
                        negatiftoplam += sayi;
                    else
                        pozitiftoplam += sayi;
                }
                else
                {
                    Console.WriteLine("pozitif sayıların toplamı = " + pozitiftoplam);
                    Console.WriteLine("negatif sayıların topamı = " + negatiftoplam);

                }


            }



            Console.ReadKey();
        }
    }
}
