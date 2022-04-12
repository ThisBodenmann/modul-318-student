using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    class WordCompletion
    {
        private static Transport transport = new Transport();

        public static void AddSuggestions(ComboBox startComboBox)
        {
            try
            {
                Transport transport = new Transport();
                List<string> temp = new List<string>();
                foreach (var station in transport.GetStations(startComboBox.Text).StationList)
                {
                    temp.Add(station.Name);
                }

                List<Station> possibleStations = transport.GetStations(startComboBox.Text).StationList;
                if (possibleStations.Count != 0 && possibleStations.First() != null)
                {
                    startComboBox.Items.Clear();
                    startComboBox.Items.Add(startComboBox.Text);
                    startComboBox.Items.AddRange(temp.ToArray());
                    if (startComboBox.DroppedDown == false)
                    {
                        startComboBox.DroppedDown = true;
                    }
                    startComboBox.SelectionStart = startComboBox.Text.Length;
                }
                else
                {
                    startComboBox.DroppedDown = false;
                }
            }
            catch { }
        }
    }
}
