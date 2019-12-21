using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sistemaRestaurante
{
    static class Program
    {
        /// <summary>
        /// Ravines Iturregui Brandon A.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
