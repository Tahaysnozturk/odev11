using System;

namespace or096
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] burslar = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

            for (int i = 0; i < burslar.Length; i++)
            {
                if (burslar[i] < 500)
                {
                    double yeniBurs = burslar[i] * 1.1 + 50;
                    Console.WriteLine(yeniBurs);
                }
                else
                {
                    Console.WriteLine(burslar[i]);
                }
            }

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
