using SwissTransport.Core;
using SwissTransport.Models;
using System.Diagnostics;

namespace SwissTransportGUI
{
    public partial class SwissTransport : Form
    {
        public SwissTransport()
        {
            InitializeComponent();
        }

        Transport transport = new Transport();

        private void SearchButtonClick(object sender, EventArgs e)
        {
            if (destinationComboBox.Text != null && startComboBox.Text != null)
            {
                Stations possibleStationsStart = transport.GetStations(destinationComboBox.Text);
                Stations possibleStationsDestination = transport.GetStations(startComboBox.Text);

                if (possibleStationsStart.StationList.Count != 0 && possibleStationsDestination.StationList.Count != 0)
                {
                    Connections possibleConnections = transport.GetConnectionsByTime(destinationComboBox.Text, startComboBox.Text, Convert.ToInt32(resultNumericUpDown.Value), dateTimePicker.Value, timeDateTimePicker.Value);

                    List<CustomConnection> connectionList = new List<CustomConnection>();
                    connectionList.Clear();

                    foreach (Connection possibleConnection in possibleConnections.ConnectionList)
                    {
                        string time = possibleConnection.From.Departure.ToString()!;
                        string[] departureTime = time.Split(' ').ToArray();
                        string[] duration = possibleConnection.Duration.Split('d').ToArray();
                        CustomConnection customConnection = new CustomConnection(departureTime[1], possibleConnection.From.Platform, possibleConnection.To.Platform, duration[1], departureTime[0]);
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

        private void DepartureBoardSearchButtonClick(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine valide Station ein!");
            }
        }

        public string homeStation = "";

        private void TakeMeHomeButtonClick(object sender, EventArgs e)
        {
            if (homeStation == "")
            {
                homeStation = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie die gewünschte Station ein.", "TakeMeHome", "gewünschte Station", -1, -1);
                
            }
            destinationComboBox.Text = homeStation;
        }

        private void stationSearchButtonClick(object sender, EventArgs e)
        {
            if (searchStationComboBox.Text != null)
            {
                Stations possibleStations = transport.GetStations(searchStationComboBox.Text);

                if (possibleStations.StationList.Count != 0)
                {

                    List<PossibleStation> connectionList = new List<PossibleStation>();
                    connectionList.Clear();

                    foreach (Station possibleStation in possibleStations.StationList)
                    {
                        PossibleStation station = new PossibleStation(possibleStation.Id, possibleStation.Name);
                        connectionList.Add(station);
                    }
                    stationDataGridView.DataSource = connectionList;
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

        private void mapShowButtonClick(object sender, EventArgs e)
        {
            if (departureBoardComboBox.Text != "")
            {
                Stations possibleStations = transport.GetStations(departureBoardComboBox.Text);
                if (possibleStations.StationList.Count != 0)
                {
                    Station station = transport.GetStations(departureBoardComboBox.Text).StationList.First();
                    Process.Start(new ProcessStartInfo { FileName = @"https://www.google.com/maps/search/?api=1&query=" + station.Coordinate.XCoordinate.ToString()!.Replace(",", ".") + "," + station.Coordinate.YCoordinate.ToString()!.Replace(",", "."), UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine valide Station an!");
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine valide Station an!");
            }
        }

        private void updateComboBox(object sender, EventArgs e)
        {
            if (destinationComboBox.Text != "" && startComboBox.Text != "")
            {
                searchButton.Enabled = true;
            }
            else
            {
                searchButton.Enabled = false;
            }

            if (departureBoardComboBox.Text != "")
            {
                departureBoardSearchButton.Enabled = true;
            }
            else
            {
                departureBoardSearchButton.Enabled = false;
            }

            if (searchStationComboBox.Text != "")
            {
                stationSearchButton.Enabled = true;
            }
            else
            {
                stationSearchButton.Enabled = false;
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            updateComboBox(null!, null!);
        }

        private void mainTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == tabPage1)
            {
                searchGroupBox.TabIndex = 1;
                startGroupBox.TabIndex = 1;
                destinationGroupBox.TabIndex = 2;
                takeMeHomeGroupBox.TabIndex = 3;
                amountGroupBox.TabIndex = 4;
                timeGroupBox.TabIndex = 5;
                dateGroupBox.TabIndex = 6;

                startComboBox.TabIndex = 1;
                destinationComboBox.TabIndex = 2;
                takeMeHomeButton.TabIndex = 3;
                resultNumericUpDown.TabIndex = 4;
                timeDateTimePicker.TabIndex = 5;
                dateTimePicker.TabIndex = 6;

                this.AcceptButton = searchButton;
            }
            else if (mainTabControl.SelectedTab == tabPage2)
            {
                departureSearchGroupBox.TabIndex = 1;
                departureEnterGroupBox.TabIndex = 1;
                mapGroupBox.TabIndex = 2;
                mapShowButton.TabIndex = 2;

                this.AcceptButton = departureBoardSearchButton;
            }
            else
            {
                stationSearchGroupBox.TabIndex = 1;
                stationSearchEnterGroupBox.TabIndex = 1;
                searchStationComboBox.TabIndex = 1;

                this.AcceptButton = stationSearchButton;
            }
        }
    }
}