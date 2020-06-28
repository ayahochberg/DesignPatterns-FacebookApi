using System;
using System.Windows.Forms;


// $G$ THE-001 (-3) your grade on diagrams document - 98 please see comments inside the document. (50% of your grade).



namespace FormsUI
{

    // $G$ CSS-999 (-3) class must have access modifiers
    static class Program
    {

        // $G$ CSS-999 (-3) method must have access modifiers
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }

    }
}
