using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framily_Fracas
{
    static class Program
    {
        public static GameController gc = new GameController();
        public static SurveyBoard sb;
        public static Controller c;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            gc.LoadSounds();
            sb = new SurveyBoard();
            c = new Controller();
            Application.Run(new MultiFormContext(sb, c));

        }

        public static void CenterControl(Control control, bool horizontal = true, bool vertical = true)
        {
            if (horizontal)
            {
                control.Left = (control.Parent.Width - control.Width) / 2;
            }

            if (vertical)
            {
                control.Top = (control.Parent.Height - control.Height) / 2;
            }
        }

    }
}
