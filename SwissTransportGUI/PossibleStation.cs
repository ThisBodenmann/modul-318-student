using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    internal class PossibleStation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public PossibleStation(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
