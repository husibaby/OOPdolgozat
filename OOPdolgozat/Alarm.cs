using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPdolgozat
{
    internal class Alarm
    {
        //Az ébresztés óráját tárolja (0-23 vagy 1-12)
        public int alarmHour {  get; set; }
        // Az ébresztés perceit tárolja (0-59).
        public int alarmMinute { get; set; }
        //Egy logikai érték, amely jelzi, hogy az ébresztés engedélyezve van-e
        public bool isAlarmOn { get; set; }


        //konstruktor
        public Alarm(int alarmHour, int alarmMinute, bool isAlarmOn)
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
            this.isAlarmOn = isAlarmOn;
        }

        //metódusok
        //Beállítja az ébresztés időpontját a megadott értékekre. [nincs visszatérési érték]
        public void SetAlarm(int hour, int minute)
        { 
            alarmHour = hour;
            alarmMinute = minute;
        }
        //Engedélyezi az ébresztést
        public void TurnOnAlarm()
        { 
            if(!isAlarmOn) 
            {
                isAlarmOn = true;
                Console.WriteLine("Az ébresztő bekapcsolva.");
            }
            else
            {
                Console.WriteLine("Az ébresztő már be van kapcsolva.");
            }
        }
        //Letiltja az ébresztést
        public void TurnOffAlarm()
        {
            if (isAlarmOn)
            {
                isAlarmOn = false;
                Console.WriteLine("Az ébresztő kikapcsolva.");
            }
            else
            {
                Console.WriteLine("Az ébresztő már ki van kapcsolva.");
            }
        }
        //Ellenőrzi, hogy az ébresztési időpont elérkezett-e, és visszaadja a találat eredményét. (BOOL)
        public bool IsAlarmTime(int hour, int minute)
        { 
            return alarmHour == hour && alarmMinute == minute;
        }
    }
}
