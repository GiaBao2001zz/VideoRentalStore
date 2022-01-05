using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            var Main_form = new Report();
            
            Application.Run(Main_form);
=======

            var Main_form = new Login();
            Main_form.Show();
            Application.Run();
>>>>>>> d129ed65572b6c7ebb32d420bc0bcc91bc0a2b87

        }
    }
}
