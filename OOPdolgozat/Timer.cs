using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPdolgozat
{
    internal class Timer
    {//A hátralévő időt másodpercekben tárolja.
        public int remainingSecond { get; set; }

        //konstruktor
        public Timer(int remainingSecond)
        {
            this.remainingSecond = remainingSecond;
        }

        //metódusok
        //Beállítja az időzítőt a megadott időre másodpercekben
        public void SetTime(int seconds)
        { 
            remainingSecond = seconds;
        }
        //Elindítja az időzítőt, visszaszámlálva a beállított időig, és közben kiírja az eltelt időt a konzolra.
        public void StartTimer()
        { 
            while (remainingSecond > 0)
            {
                Console.WriteLine($"hátralévő idő: {remainingSecond} másodperc");
                Thread.Sleep(1000); //vár 1 másodpercet
                remainingSecond--;
            }
            Console.WriteLine("Az időzítő lejárt!");
        }
    }
}
