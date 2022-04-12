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

        private void searchButtonClick(object sender, EventArgs e)
        {
            Transport transport = new Transport();

            if (startTextBox.Text != null && destinationTextBox.Text != null)
            {
                Stations possibleStationsStart = transport.GetStations(startTextBox.Text);
                Stations possibleStationsDestination = transport.GetStations(destinationTextBox.Text);

                if (possibleStationsStart.StationList.Count != 0 && possibleStationsDestination.StationList.Count != 0)
                {
                    Connections possibleConnections = transport.GetConnections(startTextBox.Text, destinationTextBox.Text);

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
    }
}