using System;
using System.Windows.Forms;

namespace NEWHospital.WindowsForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new BazaForm());
            //Application.Run(new AddNewForm());

            Application.Run(new MenuForm());
        }
    }
}
