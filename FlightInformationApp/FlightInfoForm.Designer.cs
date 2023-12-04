namespace AssigmentVIII2
{
    partial class FlightInfoForm
    {
        private Label lblFlightId;
        private Label lblOrigin;
        private Label lblDestination;
        private Label lblDateTime;
        private TextBox txtFlightId;
        private TextBox txtOrigin;
        private TextBox txtDestination;
        private DateTimePicker dateTimePicker;
        private Button btnSave;
        private Button btnShowSummary;

        private void InitializeComponent()
        {
            lblFlightId = new Label();
            lblOrigin = new Label();
            lblDestination = new Label();
            lblDateTime = new Label();
            txtFlightId = new TextBox();
            txtOrigin = new TextBox();
            txtDestination = new TextBox();
            dateTimePicker = new DateTimePicker();
            btnSave = new Button();
            btnShowSummary = new Button();
            SuspendLayout();
            // 
            // lblFlightId
            // 
            lblFlightId.Location = new Point(10, 10);
            lblFlightId.Name = "lblFlightId";
            lblFlightId.Size = new Size(100, 23);
            lblFlightId.TabIndex = 0;
            lblFlightId.Text = "Flight ID:";
            // 
            // lblOrigin
            // 
            lblOrigin.Location = new Point(10, 40);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(100, 23);
            lblOrigin.TabIndex = 1;
            lblOrigin.Text = "Origin:";
            // 
            // lblDestination
            // 
            lblDestination.Location = new Point(10, 70);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(100, 23);
            lblDestination.TabIndex = 2;
            lblDestination.Text = "Destination:";
            // 
            // lblDateTime
            // 
            lblDateTime.Location = new Point(10, 100);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(100, 23);
            lblDateTime.TabIndex = 3;
            lblDateTime.Text = "Date and Time:";
            // 
            // txtFlightId
            // 
            txtFlightId.Location = new Point(120, 10);
            txtFlightId.Name = "txtFlightId";
            txtFlightId.Size = new Size(150, 23);
            txtFlightId.TabIndex = 4;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(120, 40);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(150, 23);
            txtOrigin.TabIndex = 5;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(120, 70);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(150, 23);
            txtDestination.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(120, 100);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(150, 23);
            dateTimePicker.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 130);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnShowSummary
            // 
            btnShowSummary.Location = new Point(120, 129);
            btnShowSummary.Name = "btnShowSummary";
            btnShowSummary.Size = new Size(150, 23);
            btnShowSummary.TabIndex = 9;
            btnShowSummary.Text = "Show Summary";
            btnShowSummary.Click += btnShowSummary_Click;
            // 
            // FlightInfoForm
            // 
            ClientSize = new Size(304, 171);
            Controls.Add(lblFlightId);
            Controls.Add(lblOrigin);
            Controls.Add(lblDestination);
            Controls.Add(lblDateTime);
            Controls.Add(txtFlightId);
            Controls.Add(txtOrigin);
            Controls.Add(txtDestination);
            Controls.Add(dateTimePicker);
            Controls.Add(btnSave);
            Controls.Add(btnShowSummary);
            Name = "FlightInfoForm";
            Text = "Niko Flight";
            FormClosing += FlightInfoForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
