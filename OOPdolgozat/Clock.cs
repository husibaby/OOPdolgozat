using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPdolgozat
{
    internal class Clock
        //adattagok

    {   //aktuális óra értékét tárolja (0-23 vagy 1-12)
        public int hour {  get; set; }
        //aktuális perc értékét tárolja (0-59)
        public int minute { get; set; }
        //aktuális másodperc értékét tárolja (0-59)
        public int second { get; set; }
        //óra időzónáját tárolja, például "UTC+2
        public string timeZone { get; set; }
        //ogikai érték, amely azt jelzi, hogy az óra 24 órás vagy 12 órás formátumban jelenítse meg az időt
        public bool is24HourFormat {  get; set; }

        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.timeZone = timeZone;
            this.is24HourFormat = is24HourFormat;
        }

        //metódusok
        //Beállítja az óra, perc és másodperc értékeket a megadott értékekre
        public void SetTime(int hour, int minute, int second)
        {
            hour = hour;
            minute = minute;
            second = second;
        }
        //Kiírja az aktuális időt a konzolra a kiválasztott időformátumban és az időzónával
        public void DisplayTime()
        {
            Console.WriteLine($"{hour}:{minute}:{second}, {timeZone}");
        }
        //Beállítja az időzónát a megadott értékre
        public void SetTimeZone(string timeZone)
        {
            timeZone = timeZone;
        }
        //Vált az időformátum között (24 órás és 12 órás között)
        public void ToggleTimeFormat()
        { 
            if(is24HourFormat && hour > 12)
            {
                hour -= 12;
                is24HourFormat = false;
            }
            else if(!is24HourFormat && hour <= 12 && hour + 12 < 24) 
            {
                hour += 12;
                is24HourFormat = true;
            }
        }
    }
}
