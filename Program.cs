using System;

namespace mutlak_kare_alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen sayı adedini giriniz : ");
            int sayiAdeti = int.Parse(Console.ReadLine());
            int[] dizi = SayiDizisiOlustur(sayiAdeti);
            DegerToplaVeYazdir(67, dizi);
        }

        static void DegerToplaVeYazdir(int deger, int[] dizi)
        {
            int kucukToplam = 0;
            int buyukToplam = 0;
            foreach (int sayi in dizi)
            {
                if(sayi < deger)
                    kucukToplam += deger - sayi;
                else
                    buyukToplam += Convert.ToInt32(Math.Pow(Math.Abs(deger - sayi), 2)); 
            }

            Console.WriteLine($"Çıktı : {kucukToplam} {buyukToplam}");
        }
        static int[] SayiDizisiOlustur(int diziLenght)
        {
            int[] dizi = new int[diziLenght];
            for (int i = 0; i < diziLenght; i++)
            {
                Console.Write($"{i + 1}. elemanı giriniz : ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            return dizi;
        }
    }
}
