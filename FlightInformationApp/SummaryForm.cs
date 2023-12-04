using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigmentVIII2
{
    public partial class SummaryForm : Form
    {
        private List<Flight> flights;

        public SummaryForm(List<Flight> flights)
        {
            InitializeComponent();
            this.flights = flights;
            ShowFlights(); 
        }

        public void ShowFlights()
        {
            DisplayFlights();
        }

        private void DisplayFlights()
        {
            foreach (var flight in flights)
            {
                listBoxFlights.Items.Add($"Flight ID: {flight.FlightId}, Origin: {flight.Origin}, Destination: {flight.Destination}, DateTime: {flight.DateTime}");
            }
        }
    }
}
