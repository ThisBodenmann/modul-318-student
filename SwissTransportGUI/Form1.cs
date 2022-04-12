using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Transport transport = new Transport();

        private void SearchButtonClick(object sender, EventArgs e)
        {
            if (startComboBox.Text != null && destinationComboBox.Text != null)
            {
                Stations possibleStationsStart = transport.GetStations(startComboBox.Text);
                Stations possibleStationsDestination = transport.GetStations(destinationComboBox.Text);

                if (possibleStationsStart.StationList.Count != 0 && possibleStationsDestination.StationList.Count != 0)
                {
                    Connections possibleConnections = transport.GetConnections(startComboBox.Text, destinationComboBox.Text);

                    List<CustomConnection> connectionList = new List<CustomConnection>();
                    connectionList.Clear();

                    foreach (Connection possibleConnection in possibleConnections.ConnectionList)
                    {
                        string time = possibleConnection.From.Departure.ToString()!;
                        string[] departureTime = time.Split(' ').ToArray();
                        string[] duration = possibleConnection.Duration.Split('d').ToArray();
                        CustomConnection customConnection = new CustomConnection(possibleConnection.From.Station.Name, possibleConnection.To.Station.Name, departureTime[0], departureTime[1], duration[1], possibleConnection.From.Platform, possibleConnection.To.Platform);
                        connectionList.Add(customConnection);
                    }
                    connectionsDataGridView.DataSource = connectionList;
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine valide Station ein!");
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie beide Stationen an!");
            }


        }

        private void ComboBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
            {
                var startCombobox = (ComboBox)sender;
                WordCompletion.AddSuggestions(startCombobox);
            }
        }

        private void departureBoardSearchButtonClick(object sender, EventArgs e)
        {
            Stations startStation = transport.GetStations(departureBoardComboBox.Text);
            if (startStation.StationList.Count != 0 && departureBoardComboBox.Text != "")
            {
                StationBoardRoot stationBoardRoot = transport.GetStationBoard(departureBoardComboBox.Text, "0");

                List<CustomDepartureConnection> connectionList = new List<CustomDepartureConnection>();
                connectionList.Clear();
                
                foreach (StationBoard stationBoard in stationBoardRoot.Entries)
                {
                    string time = stationBoard.Stop.Departure.ToString();
                    string[] departureTime = time.Split(' ').ToArray();
                    CustomDepartureConnection customDepartureConnection = new CustomDepartureConnection(stationBoard.To, departureTime[0], departureTime[1], stationBoard.Number, stationBoard.Operator);
                    connectionList.Add(customDepartureConnection);
                }
                departureBoardDataGridView.DataSource = connectionList;
            } else
            {
                MessageBox.Show("Bitte geben Sie eine valide Station ein!");
            }
        }
    }
}