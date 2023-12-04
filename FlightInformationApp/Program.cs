using System;
using System.Windows.Forms;

namespace AssigmentVIII2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FlightInfoForm()); // Change this line to the form you want to start with
        }
    }
}
