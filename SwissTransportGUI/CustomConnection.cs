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
        public string Start { get; set; }
        public string Destination { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Duration { get; set; }
        public string DeparturePlatform { get; set; }
        public string ArrivalPlatform { get; set; }

        public CustomConnection(string start, string destination, string date, string time, string duration, string departurePlatform, string arrivalPlatform)
        {
            Start = start;
            Destination = destination;
            Date = date;
            Time = time;
            Duration = duration;
            DeparturePlatform = departurePlatform;
            ArrivalPlatform = arrivalPlatform;
        }
    }
}
