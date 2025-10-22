using System;
using System.Windows.Forms;

namespace SimpleHMS
{
    // Main program class - Entry point of the application
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// This method runs when the application starts
        /// </summary>
        [STAThread] // Single-threaded apartment - required for Windows Forms
        static void Main()
        {
            // Enable visual styles for modern look
            Application.EnableVisualStyles();

            // Use compatible text rendering
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (MainForm)
            Application.Run(new MainForm());
        }
    }
}