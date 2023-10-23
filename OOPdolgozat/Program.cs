using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPdolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock myClock= new Clock (12, 30, 45, "UTC+2", true );

            List<Alarm> alarms = new List<Alarm>
            {
                new Alarm (6, 0, true),
                new Alarm (8, 0, true)
            };

            Timer myTimer = new Timer(10);

            myClock.DisplayTime();

            int testHour = 6; //DateTime.Now.Hour;
            int testMinute = 0; //DateTime.Now.Minute;

            foreach (var alarm in alarms)
            {
                if (alarm.IsAlarmTime(testHour, testMinute))
                {
                    Console.WriteLine("Az ébresztő megszólalt.");
                }
            }

            myTimer.StartTimer();

            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;
            int currentSecond = DateTime.Now.Second;
            string currentTimezone = "UTC+2";
            bool currentTimeFormat = true;

            Clock myCurrentClock = new Clock(currentHour, currentMinute, currentSecond, currentTimezone, currentTimeFormat);
            myCurrentClock.DisplayTime();

            Console.ReadLine();
        }
    }
}
