using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AssigmentVIII2
{
    public partial class FlightInfoForm : Form
    {
        private List<Flight> flights = new List<Flight>();

        public FlightInfoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFlightId.Text) ||
                string.IsNullOrEmpty(txtOrigin.Text) ||
                string.IsNullOrEmpty(txtDestination.Text) ||
                string.IsNullOrEmpty(dateTimePicker.Text))
            {
                MessageBox.Show("Please enter all required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Flight newFlight = new Flight
            {
                FlightId = txtFlightId.Text,
                Origin = txtOrigin.Text,
                Destination = txtDestination.Text,
                DateTime = dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm")
            };


            flights.Add(newFlight);


            ClearInputFields();


            MessageBox.Show("Flight information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearInputFields()
        {
            txtFlightId.Text = string.Empty;
            txtOrigin.Text = string.Empty;
            txtDestination.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {

            SummaryForm summaryForm = new SummaryForm(flights);
            summaryForm.Show();
        }

        private void FlightInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Please use the 'Show Summary' button to view entered flights.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
