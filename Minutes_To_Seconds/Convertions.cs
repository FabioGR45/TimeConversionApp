using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutes_To_Seconds
{
    public class Convertions
    {

        public string baseConvertionType;
        public string DesiredConvertionType;

        public void MinutesToSeconds(double minutes) {

            var seconds = minutes * 60;
            Console.WriteLine($"\n{minutes} minutes equals {seconds} seconds");

        }

        public void SecondsToMinutes(double seconds) {

            var minutes = seconds / 60;
            Console.WriteLine($"\n{seconds} seconds equals {minutes} minutes");
        
        }

    }
}
