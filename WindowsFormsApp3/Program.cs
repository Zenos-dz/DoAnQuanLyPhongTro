using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hieuuu\source\repos\WindowsFormsApp3\WindowsFormsApp3\csdl\QUANLYTRO.mdf;Integrated Security=True"
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
