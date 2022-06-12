using System;
using System.Threading;

namespace WarGame.Another_Library
{
    public class EffectClass 
    {
        public static void LoadingScreen()
        {

            Console.WriteLine("Hoşgeldiniz ");
            Thread.Sleep(700);

            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
                Thread.Sleep(200);
            }
            Console.WriteLine("");
            Thread.Sleep(200);
            Console.WriteLine("Yükleme Başarılı ");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
