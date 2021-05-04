using System;

namespace ConsoleApp1
{
    class Program
    {
        static int  sonuc = 1;
        static int Faktoriyel(int sayi)
        {
            if (sayi == 0 || sayi == 1)
                return 1;
            if (1 < sayi)
            {
                sayi--;
                sonuc *= sayi;
              Faktoriyel(sayi);
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.Write("  Sayı : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = Faktoriyel(sayi + 1);
            Console.WriteLine("  " + sayi + "!" + " : " + faktoriyel);
            Console.Read();
        }
    }
}
