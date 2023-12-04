namespace AssigmentVIII2
{
    partial class SummaryForm
    {
        private System.Windows.Forms.ListBox listBoxFlights;

        private void InitializeComponent()
        {
            // Form
            this.ClientSize = new System.Drawing.Size(500, 400); 
            this.Text = "FlightList"; 

            // listBoxFlights
            this.listBoxFlights = new System.Windows.Forms.ListBox();
            this.listBoxFlights.FormattingEnabled = true;
            this.listBoxFlights.Location = new System.Drawing.Point(10, 10);
            this.listBoxFlights.Name = "listBoxFlights";
            this.listBoxFlights.Size = new System.Drawing.Size(460, 340); 
            this.Controls.Add(this.listBoxFlights);


        }
    }
}
