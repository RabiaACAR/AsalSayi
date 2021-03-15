using System;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            AsalMi(sayi);

            static void AsalMi(int sayi)
            {
                int value = 0;
                for (int i = 2; i<sayi; i++)
                {
                   if (sayi%i==0)
                    {
                        value += 1;
                    }
                }
                if (value>0)
                {
                    Console.WriteLine(sayi +" "+ " Asal sayı değildir.");
                }
                else
                {
                        Console.WriteLine(sayi+ " " + "Asal sayıdır.");
                }
                
                
            }
        }
    }
}
