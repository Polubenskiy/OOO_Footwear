using System;
using System.Windows.Forms;

namespace OOO_Footwear
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            //ExcelHelper excelHelper = new ExcelHelper();
            //WordHelper wordHelper = new WordHelper();
            SQLDatabaseHelper.DatabaseContext = new Entities.Footwear();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
