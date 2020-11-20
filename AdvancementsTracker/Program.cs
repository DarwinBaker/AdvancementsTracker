using AdvancementsTracker.Forms;
using System;
using System.Windows.Forms;

namespace AdvancementsTracker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Images.LoadImages();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain());
        }
    }
}
