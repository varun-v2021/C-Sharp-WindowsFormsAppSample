using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Displays two windows simultaneously, one of default form and one form2
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MulitFormContext(new Form(), new Form2()));

            //Displays two windows of form2 simultaneously
            //var form1 = new Form1();
            //var form2 = new Form2();
            //form1.Show();
            //form2.Show();
            //Application.Run();
        }
    }
}
