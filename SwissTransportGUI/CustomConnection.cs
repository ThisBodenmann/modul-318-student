using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    internal class CustomConnection
    {
        public string Time { get; set; }
        public string DeparturePlatform { get; set; }
        public string ArrivalPlatform { get; set; }
        public string Duration { get; set; }
        public string Date { get; set; }

        public CustomConnection(string time, string departurePlatform, string arrivalPlatform, string duration, string date)
        {
            Date = date;
            Time = time;
            Duration = duration;
            if (departurePlatform != null)
            {
                DeparturePlatform = departurePlatform;
            }
            else
            {
                DeparturePlatform = "-";
            }
            if (arrivalPlatform != null)
            {
                ArrivalPlatform = arrivalPlatform;
            }
            else
            {
                ArrivalPlatform = "-";
            } 
        }
    }
}
