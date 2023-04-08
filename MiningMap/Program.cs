using System;
using System.Windows.Forms;

namespace MiningMap
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            var presenter = new Presenter(mainForm);
            Application.Run(mainForm);
        }
    }
}
