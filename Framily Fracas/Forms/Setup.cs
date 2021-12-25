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
    public partial class Setup : Form
    {

        private Year last = Program.gc.currentYear;
        public Setup()
        {
            InitializeComponent();
            CheckStart();
        }

        private void CheckStart()
        {
            if (!String.IsNullOrEmpty(txt_fram1.Text) &&
                !String.IsNullOrEmpty(txt_fram2.Text) &&
                Program.gc.currentYear != Year.no)
            {
                btn_Start.Enabled = true;
            }
            else
            {
                btn_Start.Enabled = false;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Program.gc.framily1 = txt_fram1.Text;
            Program.gc.framily2 = txt_fram2.Text;

            Program.gc.fram1.Clear();
            Program.gc.fram1.Add(txt_play1_fram1.Text);
            if (!String.IsNullOrEmpty(txt_play2_fram1.Text)) Program.gc.fram1.Add(txt_play2_fram1.Text);
            if (!String.IsNullOrEmpty(txt_play3_fram1.Text)) Program.gc.fram1.Add(txt_play3_fram1.Text);
            if (!String.IsNullOrEmpty(txt_play4_fram1.Text)) Program.gc.fram1.Add(txt_play4_fram1.Text);
            if (!String.IsNullOrEmpty(txt_play5_fram1.Text)) Program.gc.fram1.Add(txt_play5_fram1.Text);

            Program.gc.fram2.Clear();
            Program.gc.fram2.Add(txt_play1_fram2.Text);
            if (!String.IsNullOrEmpty(txt_play2_fram2.Text)) Program.gc.fram2.Add(txt_play2_fram2.Text);
            if (!String.IsNullOrEmpty(txt_play3_fram2.Text)) Program.gc.fram2.Add(txt_play3_fram2.Text);
            if (!String.IsNullOrEmpty(txt_play4_fram2.Text)) Program.gc.fram2.Add(txt_play4_fram2.Text);
            if (!String.IsNullOrEmpty(txt_play5_fram2.Text)) Program.gc.fram2.Add(txt_play5_fram2.Text);

            if (last != Program.gc.currentYear)
            {
                Program.gc.InitializeSurveys();
            }

            this.Close();
        }

        private void txt_fram1_TextChanged(object sender, EventArgs e)
        {
            CheckStart();
        }

        private void txt_fram2_TextChanged(object sender, EventArgs e)
        {
            CheckStart();
        }

        private void txt_play1_fram1_TextChanged(object sender, EventArgs e)
        {
            //CheckStart();
        }

        private void txt_play1_fram2_TextChanged(object sender, EventArgs e)
        {
            //CheckStart();
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            Program.gc.currentYear = Year.y06;
            highlight(btn_06);
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            Program.gc.currentYear = Year.y16;
            highlight(btn_16);
        }

        private void btn_17_Click(object sender, EventArgs e)
        {
            Program.gc.currentYear = Year.y17;
            highlight(btn_17);
        }

        private void btn_18_Click(object sender, EventArgs e)
        {
            Program.gc.currentYear = Year.y18;
            highlight(btn_18);
        }

        private void btn_19_Click(object sender, EventArgs e)
        {
            Program.gc.currentYear = Year.y19;
            highlight(btn_19);
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            Program.gc.currentYear = Year.y20;
            highlight(btn_20);
        }

        private void highlight(Control c)
        {
            c.BackColor = SystemColors.ControlDark;
            CheckStart();
        }

        private void clearHighlight()
        {
            btn_06.BackColor = SystemColors.Control;
            btn_16.BackColor = SystemColors.Control;
            btn_17.BackColor = SystemColors.Control;
            btn_18.BackColor = SystemColors.Control;
            btn_19.BackColor = SystemColors.Control;
            btn_20.BackColor = SystemColors.Control;
        }
    }
}
