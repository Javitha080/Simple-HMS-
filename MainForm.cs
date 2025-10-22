using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleHMS
{
    // Main menu form - First screen after application starts
    public partial class MainForm : Form
    {
        // Constructor - Initializes the form
        public MainForm()
        {
            InitializeComponent();
        }

        // Initialize all form components
        private void InitializeComponent()
        {
            // Set form properties
            this.Text = "Hospital Management System - Main Menu";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Create title label
            Label lblTitle = new Label();
            lblTitle.Text = "Hospital Management System";
            lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTitle.Location = new Point(100, 30);
            lblTitle.Size = new Size(400, 40);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Create Patient Registration button
            Button btnPatient = new Button();
            btnPatient.Text = "Patient Registration";
            btnPatient.Size = new Size(300, 50);
            btnPatient.Location = new Point(150, 100);
            btnPatient.Font = new Font("Arial", 12);
            btnPatient.Click += BtnPatient_Click; // Attach click event
            
            // Add tooltip for Patient button
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnPatient, "Click to manage patient records - Add, Update, Delete patients");

            // Create Doctor Registration button
            Button btnDoctor = new Button();
            btnDoctor.Text = "Doctor Registration";
            btnDoctor.Size = new Size(300, 50);
            btnDoctor.Location = new Point(150, 170);
            btnDoctor.Font = new Font("Arial", 12);
            btnDoctor.Click += BtnDoctor_Click; // Attach click event
            tooltip.SetToolTip(btnDoctor, "Click to manage doctor records - Add, Update, Delete doctors");

            // Create Appointments button
            Button btnAppointment = new Button();
            btnAppointment.Text = "Appointments";
            btnAppointment.Size = new Size(300, 50);
            btnAppointment.Location = new Point(150, 240);
            btnAppointment.Font = new Font("Arial", 12);
            btnAppointment.Click += BtnAppointment_Click; // Attach click event
            tooltip.SetToolTip(btnAppointment, "Click to manage appointments - Book, Update, Cancel appointments");

            // Add all controls to the form
            this.Controls.Add(lblTitle);
            this.Controls.Add(btnPatient);
            this.Controls.Add(btnDoctor);
            this.Controls.Add(btnAppointment);
        }

        // Event handler for Patient Registration button
        private void BtnPatient_Click(object sender, EventArgs e)
        {
            // Create and show Patient form
            PatientForm patientForm = new PatientForm();
            patientForm.ShowDialog(); // Show as modal dialog
        }

        // Event handler for Doctor Registration button
        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            // Create and show Doctor form
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.ShowDialog(); // Show as modal dialog
        }

        // Event handler for Appointments button
        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            // Create and show Appointment form
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog(); // Show as modal dialog
        }
    }
}

