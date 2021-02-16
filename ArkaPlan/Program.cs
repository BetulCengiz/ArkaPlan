using System;

namespace ArkaPlan
{
    class Program
    {
        static void Main(string[] args)
        {   
        
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Clear();
            //Console.Title = "Başlık";
            //Console.WriteLine("Merhaba bu bir arka plan denemesidir");
            // boxing and unboxing

            Console.Write("0'dan 15'e kadar bir  sayı giriniz");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor = renk;
            Console.Clear();


        }
    }
}
