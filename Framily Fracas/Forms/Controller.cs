using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framily_Fracas
{
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();
        }

        public void UpdateQuestion(Question q)
        {
            controllerNewQuestion1.UpdateQuestion(q);
        }

        public void StartFastMoney()
        {
            controllerNewQuestion1.StartFastMoney();
        }
    }
}
