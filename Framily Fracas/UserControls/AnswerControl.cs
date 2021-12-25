using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framily_Fracas
{
    public partial class AnswerControl : UserControl
    {
        public AnswerControl()
        {
            InitializeComponent();
        }

        public Answer answer;
        private int number;
        private bool controller;

        public void SetAnswer(Answer a, int num, bool c)
        {
            panel1.BackColor = Color.DodgerBlue;

            answer = a;
            number = num;
            controller = c;

            RevealAnswer(controller);
        }

        public void RevealAnswer(bool reveal, bool sound = false)
        {
            if (sound)
            {

            }
            if (reveal)
            {
                lbl_Answer.Text = answer.text;
                lbl_Points.Text = answer.points.ToString();
                lbl_Points.Visible = true;
                panel2.Visible = true;
            }
            else
            {
                lbl_Answer.Text = number.ToString();
                if (lbl_Answer.Text == "0") lbl_Answer.Text = "";
                lbl_Points.Visible = false;
                panel2.Visible = false;
            }
            ResizeControls();
        }

        private void ResizeControls()
        {
            Program.CenterControl(lbl_Answer);
            Program.CenterControl(lbl_Points);
        }

        private void AnswerControl_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }
        public void CenterControl(Control control, bool horizontal = true, bool vertical = true)
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
        
        private void pnl_Answer_MouseEnter(object sender, EventArgs e)
        {
            if (controller)
            {
                pnl_Answer.BackColor = Color.Gold;
                this.BackColor = Color.Gold;
            }
        }

        private void pnl_Answer_MouseLeave(object sender, EventArgs e)
        {
            if (controller)
            {
                pnl_Answer.BackColor = Color.White;
                this.BackColor = Color.Gray;
            }
        }

        private void AnswerControl_Click(object sender, EventArgs e)
        {
            
        }

        private void pnl_Answer_MouseClick(object sender, MouseEventArgs e)
        {
            bool done = !answer.revealed;
            if (controller)
            {
                answer.revealed = done;
                if (done)
                {
                    pnl_Answer.BackColor = Color.Gold;
                    this.BackColor = Color.Gold;
                    panel1.BackColor = Color.Goldenrod;
                    playDing();
                }
                else
                {
                    panel1.BackColor = Color.DodgerBlue;
                    pnl_Answer.BackColor = Color.White;
                    this.BackColor = Color.Gray;
                }

                Program.gc.UpdateAnswer(answer);
            }
        }

        private void playDing()
        {
            if (Program.gc.Ding.IsLoadCompleted) Program.gc.Ding.Play();
        }
    }
}
