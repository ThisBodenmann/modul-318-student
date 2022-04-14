using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    internal class CustomDepartureConnection
    {
        public string Destination { get; set; }
        public string Time { get; set; }
        public string Number { get; set; }
        public string Operator { get; set; }
        public string Date { get; set; }

        public CustomDepartureConnection(string destination, string date, string time, string number, string operat)
        {
            Destination = destination;
            Date = date;
            Time = time;
            Number = number;
            Operator = operat;
        }
    }
}
