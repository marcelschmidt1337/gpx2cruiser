using System;
using GPX2Cruiser.Shared;
using System.Windows.Forms;

namespace GPX2Cruiser.Windows
{
    static class Program
    {
        public static Main GPX2Cruiser { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GPX2Cruiser = new Main();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
